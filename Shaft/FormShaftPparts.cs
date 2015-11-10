using System;
using System.ComponentModel;
using System.Windows.Forms;
using Inventor;

using System.Collections.Generic;

using System.Data;
using System.Text;


namespace Shaft
{
    public partial class Form_ShaftPparts : Form
    {
        Inventor.Application ThisApplication = null;

        public Form_ShaftPparts()
        {
           InitializeComponent();

           tbWidth.Text = "0";
           tbHeight.Text = "0";

           comboBoxStartEdgeType.SelectedItem = "Standart";
           comboBoxEndEdgeType.SelectedItem = "Standart";
            
           try
           {
             ThisApplication = (Inventor.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application");
           }
           catch
           {
               // Если Inventor не запустился
               System.Windows.Forms.MessageBox.Show("Need to start an Inventor session - Exiting");
               return;
           }
        }

        PlanarSketch oSketch0 = default(PlanarSketch);
        TransientGeometry oTransGeom = default(TransientGeometry);
        SketchEntitiesEnumerator oRectangleLines = default(SketchEntitiesEnumerator);
        
        PartDocument partDoc = default(PartDocument);
        PartComponentDefinition oPartCompDef = default(PartComponentDefinition);
        Profile oProfile0 = default(Profile);

        private class PartOfShaft : Form_ShaftPparts
        {
            public int PartWidth { get; set; }
            public int PartHeight { get; set; }

            public void CRectangle(int X, int Y, int StartPointX)
            {
                // Попытка установить связь с активным чертежом.
                try
                {
                    Object actObj = ThisApplication.ActiveEditObject;
                    oSketch0 = (PlanarSketch)actObj;
                }
                catch
                {
                    MessageBox.Show("A sketch must be active.");
                    return;
                }

                // Установление связи с воспомогательной геометрией.
                oTransGeom = ThisApplication.TransientGeometry;

                oRectangleLines = oSketch0.SketchLines.AddAsTwoPointRectangle(oTransGeom.CreatePoint2d(StartPointX, 0), oTransGeom.CreatePoint2d(StartPointX + X, Y));
            }

        }

        private int IndexOfSelectedItem = 0;
        private int TotalLenght1 = 0;
        private void AddShaftElement(object sender, EventArgs e)
        {
           // С целью упрощения принято, что размеры ступеней вала будут задаватся целыми числами.
           try
           {
                Convert.ToInt32(tbHeight.Text);
                Convert.ToInt32(tbWidth.Text);
                // Пустые и нулевые значения размеров - неприемлемы.
                if ((!string.IsNullOrEmpty(tbHeight.Text)) && (!string.IsNullOrEmpty(tbWidth.Text)) && ((Convert.ToInt32(tbHeight.Text) > 0) && (Convert.ToInt32(tbWidth.Text) > 0))) //* & -> &&
                    {
                        // Недопустимый ввод подряд двох ступеней вала с одинаковой высотой.
                        //Тогда невозможно построить фаску или кромку между ними. 
                        if (HeightOfNeighbourElementsIsDifferent())
                        {
                            btnDeleteElement.Enabled = true;

                            if ((listViewShaftElements.Items.Count >= 0) & (listViewShaftElements.SelectedItems.Count == 0))
                            {
                                IndexOfSelectedItem = listViewShaftElements.Items.Count - 1;
                            }
                            else if ((listViewShaftElements.Items.Count > 0) & (listViewShaftElements.SelectedItems.Count == 1))
                            {
                                IndexOfSelectedItem = listViewShaftElements.SelectedItems[0].Index;
                            }

                            ListViewItem lvShaftEl = new ListViewItem("0");
                            lvShaftEl.SubItems.Add(tbHeight.Text);
                            lvShaftEl.SubItems.Add(tbWidth.Text);
                            lvShaftEl.SubItems.Add(comboBoxStartEdgeType.Text);
                            lvShaftEl.SubItems.Add(comboBoxStartEdgeSize.Text);
                            lvShaftEl.SubItems.Add(comboBoxStartEdgeSize2_Chamfer.Text);
                            lvShaftEl.SubItems.Add(comboBoxStartAngle_Chamfer.Text);
                            lvShaftEl.SubItems.Add(comboBoxEndEdgeType.Text);
                            lvShaftEl.SubItems.Add(comboBoxEndEdgeSize.Text);
                            lvShaftEl.SubItems.Add(comboBoxEndEdgeSize2_Chamfer.Text);
                            lvShaftEl.SubItems.Add(comboBoxEndAngle_Chamfer.Text);
                            
                            listViewShaftElements.Items.Insert(++IndexOfSelectedItem, lvShaftEl);
                            listViewShaftElements.Items[IndexOfSelectedItem].Selected = true;
                            listViewShaftElements.Select();

                            TotalLenght1 = TotalLenght1 + Convert.ToInt32(tbWidth.Text);
                            tbLenghtOfShaft.Text = Convert.ToString(TotalLenght1);

                            HeightOfNeighbourElementsIsDifferent();
                        }
                    }

           }

           catch (Exception)
           {
               MessageBox.Show("Please, enter integer values!");
           }
        }

        private void RemoveShaftElement(object sender, EventArgs e)
        {
            if (listViewShaftElements.Items.Count > 0)
            {
                IndexOfSelectedItem = listViewShaftElements.SelectedItems[0].Index;
                foreach (ListViewItem eachItem in listViewShaftElements.SelectedItems)
                {
                    TotalLenght1 = TotalLenght1 - Convert.ToInt32(listViewShaftElements.SelectedItems[0].SubItems[2].Text);
                    tbLenghtOfShaft.Text = Convert.ToString(TotalLenght1);

                    listViewShaftElements.Items.Remove(eachItem);
                }


                IndexOfSelectedItem--;
                if (IndexOfSelectedItem < 0)
                {
                    IndexOfSelectedItem = 0;
                }

                if (listViewShaftElements.Items.Count == 0)
                {
                    btnDeleteElement.Enabled = false;
                }
                if (listViewShaftElements.Items.Count > 0)
                {
                    listViewShaftElements.Items[IndexOfSelectedItem].Selected = true;
                }
            }
        }

        private bool HeightOfNeighbourElementsIsDifferent()
        {
            int SimilarHeight = 0;
            int CheckHeight = 0;

            StringBuilder CheckHeight_str = new StringBuilder("Shaft 3D model can't be created when neighbour elements have the same height:");
            foreach (ListViewItem eachItem in listViewShaftElements.Items)
            {
                if ((CheckHeight == Convert.ToInt32(eachItem.SubItems[1].Text)) & (eachItem.Index > 0))
                {
                    CheckHeight_str.Append("\nElement №" + (eachItem.Index + 1) + " has equal height: " + eachItem.SubItems[1].Text + ", as element №" + (eachItem.Index));
                    SimilarHeight = 1;
                }
                CheckHeight = Convert.ToInt32(eachItem.SubItems[1].Text);
            }

            if (SimilarHeight == 1)
            {
                CheckHeight_str.Append("\nPlease, switch to Edit mode and make changes!");
                MessageBox.Show(CheckHeight_str.ToString());
                return false;
            }
            return true;
        }

        private bool ModelCreated;
        private void CreateShaft3dmodel(object sender, EventArgs e)
        {
            if (listViewShaftElements.Items.Count > 0)
            {

                if ((!ModelCreated) & (HeightOfNeighbourElementsIsDifferent()))
                {
                    PlanarSketch oSketch = default(PlanarSketch);
                    SketchPoints oSkPnts = default(SketchPoints);
                    Object actObj = ThisApplication.ActiveEditObject;
                    oSketch = (PlanarSketch)actObj;
                    oSkPnts = oSketch.SketchPoints;

                    oTransGeom = ThisApplication.TransientGeometry;
                    partDoc = (Inventor.PartDocument)ThisApplication.ActiveDocument;
                    oPartCompDef = partDoc.ComponentDefinition;

                    int TotalLenght2 = 0;
                    foreach (ListViewItem eachItem in listViewShaftElements.Items)
                    {
                        PartOfShaft POShaft = new PartOfShaft();
                        POShaft.PartHeight = Convert.ToInt32(eachItem.SubItems[1].Text);
                        POShaft.PartWidth = Convert.ToInt32(eachItem.SubItems[2].Text);
                        POShaft.CRectangle(POShaft.PartWidth, POShaft.PartHeight, TotalLenght2);
                        
                        TotalLenght2 = TotalLenght2 + POShaft.PartWidth;
                        tbLenghtOfShaft.Text = Convert.ToString(TotalLenght2);
                    }

                    // Создание центральной оси для будущего вращения прямоугольников вокруг нее.
                    Point2d CentralLine_StartPoint = oTransGeom.CreatePoint2d(0, 0);
                    Point2d CentralLine_EndPoint = oTransGeom.CreatePoint2d(TotalLenght2, 0);
                    SketchLine CentralLineForRevolveAround = default(SketchLine);
                    CentralLineForRevolveAround = oSketch.SketchLines.AddByTwoPoints(CentralLine_StartPoint, CentralLine_EndPoint);
                    
                    // Вращение.
                    oProfile0 = oSketch.Profiles.AddForSolid();
                    RevolveFeature oRevFeature = default(RevolveFeature);
                    oRevFeature = partDoc.ComponentDefinition.Features.RevolveFeatures.AddFull(oProfile0, CentralLineForRevolveAround, PartFeatureOperationEnum.kNewBodyOperation);

                    // Добавление фасок и кромок.

                    int StartPoint_X = 0, EndPoint_X = 0; 
                    double MiddlePoint_X1 = 0, MiddlePoint_X2 = 0;
                    double SizeOfTypeStart = 0, SizeOfTypeEnd = 0;
                    double AngleStart, AngleEnd, SizeOfTypeEnd1, SizeOfTypeEnd2, SizeOfTypeStart1, SizeOfTypeStart2;

                    foreach (ListViewItem eachItem in listViewShaftElements.Items)
                    {
                        Point oPointStart = default(Point);
                        oPointStart = oTransGeom.CreatePoint(StartPoint_X, Convert.ToInt32(eachItem.SubItems[1].Text));

                        MiddlePoint_X1 = StartPoint_X + Convert.ToDouble(eachItem.SubItems[2].Text) / 2 - 0.02;
                        MiddlePoint_X2 = StartPoint_X + Convert.ToDouble(eachItem.SubItems[2].Text) / 2 + 0.02;
                        StartPoint_X = StartPoint_X + Convert.ToInt32(eachItem.SubItems[2].Text);
                        Point oPointEnd = default(Point);
                        EndPoint_X = StartPoint_X;
                        oPointEnd = oTransGeom.CreatePoint(EndPoint_X, Convert.ToInt32(eachItem.SubItems[1].Text));

                        Point oPointMiddle = default(Point);
                        oPointMiddle = oTransGeom.CreatePoint(MiddlePoint_X1, Convert.ToInt32(eachItem.SubItems[1].Text));

                        Face objFaceMiddle = (Face)partDoc.ComponentDefinition.SurfaceBodies[1].LocateUsingPoint(ObjectTypeEnum.kFaceObject, oPointMiddle, 0.01);

                        Object objStart = partDoc.ComponentDefinition.SurfaceBodies[1].LocateUsingPoint(ObjectTypeEnum.kEdgeObject, oPointStart, 0.01);
                        partDoc.SelectSet.Select(objStart);


                        // Определение коллекции начальных углов.
                        EdgeCollection oEdgesStart = default(EdgeCollection);
                        oEdgesStart = ThisApplication.TransientObjects.CreateEdgeCollection();
                        oEdgesStart.Add(objStart);
                        try
                        {
                            switch (eachItem.SubItems[3].Text)
                            {
                                case "Standart":
                                    partDoc.SelectSet.Clear();
                                    break;
                                case "Fillet":
                                    SizeOfTypeStart = Convert.ToDouble(eachItem.SubItems[4].Text);
                                    FilletFeature oFilletStart = default(FilletFeature);
                                    oFilletStart = oPartCompDef.Features.FilletFeatures.AddSimple(oEdgesStart, SizeOfTypeStart);
                                    break;
                                case "Chamfer (Distance)":
                                    SizeOfTypeStart = Convert.ToDouble(eachItem.SubItems[4].Text);
                                    ChamferFeature oChamferStart_D = default(ChamferFeature);
                                    oChamferStart_D = oPartCompDef.Features.ChamferFeatures.AddUsingDistance(oEdgesStart, SizeOfTypeStart);
                                    break;
                                case "Chamfer (Distance And Angle)":
                                    SizeOfTypeStart = Convert.ToDouble(eachItem.SubItems[4].Text);
                                    AngleStart = Convert.ToDouble(eachItem.SubItems[6].Text);
                                    ChamferFeature oChamferStart_DaA = default(ChamferFeature);
                                    oChamferStart_DaA = oPartCompDef.Features.ChamferFeatures.AddUsingDistanceAndAngle(oEdgesStart, objFaceMiddle, SizeOfTypeStart, AngleStart);
                                    break;
                                case "Chamfer (Two Distances)":
                                    SizeOfTypeStart1 = Convert.ToDouble(eachItem.SubItems[4].Text);
                                    SizeOfTypeStart2 = Convert.ToDouble(eachItem.SubItems[5].Text);
                                    ChamferFeature oChamferStart_DD = default(ChamferFeature);
                                    oChamferStart_DD = oPartCompDef.Features.ChamferFeatures.AddUsingTwoDistances(oEdgesStart, objFaceMiddle, SizeOfTypeStart1, SizeOfTypeStart2);
                                    break;

                            }
                        }

                        catch
                        {
                            MessageBox.Show(eachItem.SubItems[3].Text + " " + eachItem.SubItems[4].Text + " " + eachItem.SubItems[5].Text + " " + eachItem.SubItems[6].Text);
                        }

                        Point oPointMiddle2 = default(Point);
                        oPointMiddle2 = oTransGeom.CreatePoint(MiddlePoint_X2, Convert.ToInt32(eachItem.SubItems[1].Text));
                        Face objFaceMiddle2 = (Face)partDoc.ComponentDefinition.SurfaceBodies[1].LocateUsingPoint(ObjectTypeEnum.kFaceObject, oPointMiddle2, 0.01);

                        Object objEnd = partDoc.ComponentDefinition.SurfaceBodies[1].LocateUsingPoint(ObjectTypeEnum.kEdgeObject, oPointEnd, 0.01);
                        partDoc.SelectSet.Select(objEnd);


                        // Определение коллекции конечных углов.
                        EdgeCollection oEdgesEnd = default(EdgeCollection);
                        oEdgesEnd = ThisApplication.TransientObjects.CreateEdgeCollection();
                        oEdgesEnd.Add(objEnd);

                        switch (eachItem.SubItems[7].Text)
                        {
                            case "Standart":
                                partDoc.SelectSet.Clear();
                                break;
                            case "Fillet":
                                SizeOfTypeEnd = Convert.ToDouble(eachItem.SubItems[8].Text);
                                FilletFeature oFilletEnd = default(FilletFeature);
                                oFilletEnd = oPartCompDef.Features.FilletFeatures.AddSimple(oEdgesEnd, SizeOfTypeEnd);
                                break;
                            case "Chamfer (Distance)":
                                SizeOfTypeEnd = Convert.ToDouble(eachItem.SubItems[8].Text);
                                ChamferFeature oChamferEnd_D = default(ChamferFeature);
                                oChamferEnd_D = oPartCompDef.Features.ChamferFeatures.AddUsingDistance(oEdgesEnd, SizeOfTypeEnd);
                                break;
                            case "Chamfer (Distance And Angle)":
                                SizeOfTypeEnd = Convert.ToDouble(eachItem.SubItems[8].Text);
                                AngleEnd = Convert.ToDouble(eachItem.SubItems[10].Text);
                                ChamferFeature oChamferEnd_DaA = default(ChamferFeature);
                                oChamferEnd_DaA = oPartCompDef.Features.ChamferFeatures.AddUsingDistanceAndAngle(oEdgesEnd, objFaceMiddle2, SizeOfTypeEnd, AngleEnd);
                                break;
                            case "Chamfer (Two Distances)":
                                SizeOfTypeEnd1 = Convert.ToDouble(eachItem.SubItems[8].Text);
                                SizeOfTypeEnd2 = Convert.ToDouble(eachItem.SubItems[9].Text);
                                ChamferFeature oChamferEnd_DD = default(ChamferFeature);
                                oChamferEnd_DD = oPartCompDef.Features.ChamferFeatures.AddUsingTwoDistances(oEdgesEnd, objFaceMiddle2, SizeOfTypeEnd1, SizeOfTypeEnd2);
                                break;

                        }
                    }


                    ThisApplication.ActiveView.GoHome();
                    ModelCreated = true;
                }

                else if (ModelCreated)
                {
                    MessageBox.Show("The 3d model was already created!");
                }
            }
        }


        private void comboBoxStartEdgeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStartEdgeSize.Text = null;
            comboBoxStartEdgeSize2_Chamfer.Text = null;
            comboBoxStartAngle_Chamfer.Text = null;
            
            switch (comboBoxStartEdgeType.Text)
            {
                case "Standart":
                    comboBoxStartEdgeSize.Enabled = false;
                    comboBoxStartEdgeSize2_Chamfer.Enabled = false;
                    comboBoxStartAngle_Chamfer.Enabled = false;
                    break;
                case "Fillet":
                    comboBoxStartEdgeSize.Enabled = true;
                    comboBoxStartEdgeSize.Text = "0,1";
                    comboBoxStartEdgeSize2_Chamfer.Enabled = false;
                    comboBoxStartAngle_Chamfer.Enabled = false;
                    break;
                case "Chamfer (Distance)":
                    comboBoxStartEdgeSize.Enabled = true;
                    comboBoxStartEdgeSize.Text = "0,1";
                    comboBoxStartEdgeSize2_Chamfer.Enabled = false;
                    comboBoxStartAngle_Chamfer.Enabled = false;
                    break;
                case "Chamfer (Distance And Angle)":
                    comboBoxStartEdgeSize.Enabled = true;
                    comboBoxStartEdgeSize.Text = "0,1";
                    comboBoxStartEdgeSize2_Chamfer.Enabled = false;
                    comboBoxStartAngle_Chamfer.Enabled = true;
                    comboBoxStartAngle_Chamfer.Text = "0,1";
                    break;
                case "Chamfer (Two Distances)":
                    comboBoxStartEdgeSize.Enabled = true;
                    comboBoxStartEdgeSize.Text = "0,1";
                    comboBoxStartEdgeSize2_Chamfer.Enabled = true;
                    comboBoxStartEdgeSize2_Chamfer.Text = "0,1";
                    comboBoxStartAngle_Chamfer.Enabled = false;
                    break;

            }


        }


        private void comboBoxEndEdgeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEndEdgeSize.Text = null;
            comboBoxEndEdgeSize2_Chamfer.Text = null;
            comboBoxEndAngle_Chamfer.Text = null;

            switch (comboBoxEndEdgeType.Text)
            {
                case "Standart":
                    comboBoxEndEdgeSize.Enabled = false;
                    comboBoxEndEdgeSize2_Chamfer.Enabled = false;
                    comboBoxEndAngle_Chamfer.Enabled = false;
                    break;
                case "Fillet":
                    comboBoxEndEdgeSize.Enabled = true;
                    comboBoxEndEdgeSize.Text = "0,1";
                    comboBoxEndEdgeSize2_Chamfer.Enabled = false;
                    comboBoxEndAngle_Chamfer.Enabled = false;
                    break;
                case "Chamfer (Distance)":
                    comboBoxEndEdgeSize.Enabled = true;
                    comboBoxEndEdgeSize.Text = "0,1";
                    comboBoxEndEdgeSize2_Chamfer.Enabled = false;
                    comboBoxEndAngle_Chamfer.Enabled = false;
                    break;
                case "Chamfer (Distance And Angle)":
                    comboBoxEndEdgeSize.Enabled = true;
                    comboBoxEndEdgeSize.Text = "0,1";
                    comboBoxEndEdgeSize2_Chamfer.Enabled = false;
                    comboBoxEndAngle_Chamfer.Enabled = true;
                    comboBoxEndAngle_Chamfer.Text = "0,1";
                    break;
                case "Chamfer (Two Distances)":
                    comboBoxEndEdgeSize.Enabled = true;
                    comboBoxEndEdgeSize.Text = "0,1";
                    comboBoxEndEdgeSize2_Chamfer.Enabled = true;
                    comboBoxEndEdgeSize2_Chamfer.Text = "0,1";
                    comboBoxEndAngle_Chamfer.Enabled = false;
                    break;

            }

        }


        private void radioButton_StandartMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_StandartMode.Checked == true)
            {
                btnAddElement.Enabled = true;
                
                tbHeight.DataBindings.Clear();
                tbWidth.DataBindings.Clear();
                comboBoxStartEdgeType.DataBindings.Clear();
                comboBoxStartEdgeSize.DataBindings.Clear();
                comboBoxStartEdgeSize2_Chamfer.DataBindings.Clear();
                comboBoxStartAngle_Chamfer.DataBindings.Clear();
                comboBoxEndEdgeType.DataBindings.Clear();
                comboBoxEndEdgeSize.DataBindings.Clear();
                comboBoxEndEdgeSize2_Chamfer.DataBindings.Clear();
                comboBoxEndAngle_Chamfer.DataBindings.Clear();
            }
        }


        private void radioButton_EditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_EditMode.Checked == true)
            {
                btnAddElement.Enabled = false;
            }
        }


        private void tbWidth_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_EditMode.Checked == true)
            {
                TotalLenght1 = 0;
                foreach (ListViewItem eachItem in listViewShaftElements.Items)
                {
                    TotalLenght1 = TotalLenght1 + Convert.ToInt32(eachItem.SubItems[2].Text);
                }
                tbLenghtOfShaft.Text = Convert.ToString(TotalLenght1);
            }
        }


        private void listViewShaftElements_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ((radioButton_EditMode.Checked == true) & (listViewShaftElements.SelectedItems.Count == 1))
            {
                tbHeight.DataBindings.Clear();
                tbWidth.DataBindings.Clear();
                comboBoxStartEdgeType.DataBindings.Clear();
                comboBoxStartEdgeSize.DataBindings.Clear();
                comboBoxStartEdgeSize2_Chamfer.DataBindings.Clear();
                comboBoxStartAngle_Chamfer.DataBindings.Clear();
                comboBoxEndEdgeType.DataBindings.Clear();
                comboBoxEndEdgeSize.DataBindings.Clear();
                comboBoxEndEdgeSize2_Chamfer.DataBindings.Clear();
                comboBoxEndAngle_Chamfer.DataBindings.Clear();

                tbHeight.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[1], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                tbWidth.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[2], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxStartEdgeType.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[3], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxStartEdgeSize.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[4], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxStartEdgeSize2_Chamfer.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[5], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxStartAngle_Chamfer.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[6], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxEndEdgeType.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[7], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxEndEdgeSize.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[8], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxEndEdgeSize2_Chamfer.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[9], "Text", false, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxEndAngle_Chamfer.DataBindings.Add("Text", listViewShaftElements.SelectedItems[0].SubItems[10], "Text", false, DataSourceUpdateMode.OnPropertyChanged);

            }

        }


    }
}
