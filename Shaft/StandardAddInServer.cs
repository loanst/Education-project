using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Inventor;
using Microsoft.Win32;

namespace Shaft
{
    /// <summary>
    /// This is the primary AddIn Server class that implements the ApplicationAddInServer interface
    /// that all Inventor AddIns are required to implement. The communication between Inventor and
    /// the AddIn is via the methods on this interface.
    /// </summary>
    [GuidAttribute("187856c3-b22f-43dc-8068-5d6adbe4adc5")]
    public class StandardAddInServer : Inventor.ApplicationAddInServer
    {

        #region Data Members

        // Inventor application object.
        private Inventor.Application m_inventorApplication;

        
        //button
        private AddShaftButton m_addShaftButton;

        // ribbon panel
        RibbonPanel m_partSketchShaftRibbonPanel;

        #endregion

        public StandardAddInServer()
        {
        }

        #region ApplicationAddInServer Members

        public void Activate(Inventor.ApplicationAddInSite addInSiteObject, bool firstTime)
        {
            // This method is called by Inventor when it loads the addin.
            // The AddInSiteObject provides access to the Inventor Application object.
            // The FirstTime flag indicates if the addin is loaded for the first time.

            try
            {


                // Initialize AddIn members.
                m_inventorApplication = addInSiteObject.Application;
                
                //m_inventorApplication.Caption = "Addin Loaded!!!";
                //MessageBox.Show("Addin First time");

                Button.InventorApplication = m_inventorApplication;

                //load image icons for UI items
                Icon addShaftIcon = new Icon(this.GetType(), "AddShaft.ico");

                //retrieve the GUID for this class
                GuidAttribute addInCLSID;
                addInCLSID = (GuidAttribute)GuidAttribute.GetCustomAttribute(typeof(StandardAddInServer), typeof(GuidAttribute));
                string addInCLSIDString;
                addInCLSIDString = "{" + addInCLSID.Value + "}";

                //create buttons
                m_addShaftButton = new AddShaftButton(
                    "Shaft", "Autodesk:Shaft:AddShaftCmdBtn", CommandTypesEnum.kShapeEditCmdType,
                    addInCLSIDString, "Build shaft",
                    "Helps to calculate and build shaft", addShaftIcon, addShaftIcon, ButtonDisplayEnum.kDisplayTextInLearningMode);

                //create the command category
                CommandCategory ShaftCmdCategory = m_inventorApplication.CommandManager.CommandCategories.Add("Shaft", "Autodesk:Shaft:ShaftCmdCat", addInCLSIDString);
                ShaftCmdCategory.Add(m_addShaftButton.ButtonDefinition);


                if (firstTime == true)
                {
                    //access user interface manager
                    UserInterfaceManager userInterfaceManager;
                    userInterfaceManager = m_inventorApplication.UserInterfaceManager;

                    InterfaceStyleEnum interfaceStyle;
                    interfaceStyle = userInterfaceManager.InterfaceStyle;


                    //create the UI for ribbon interface

                    //get the ribbon associated with part document
                    Inventor.Ribbons ribbons;
                    ribbons = userInterfaceManager.Ribbons;

                    Inventor.Ribbon partRibbon;
                    partRibbon = ribbons["Part"];

                    //get the tabls associated with part ribbon
                    RibbonTabs ribbonTabs;
                    ribbonTabs = partRibbon.RibbonTabs;

                    RibbonTab partSketchRibbonTab;
                    partSketchRibbonTab = ribbonTabs["id_TabSketch"];

                    //create a new panel with the tab
                    RibbonPanels ribbonPanels;
                    ribbonPanels = partSketchRibbonTab.RibbonPanels;

                    m_partSketchShaftRibbonPanel = ribbonPanels.Add("Shaft", "Autodesk:Shaft:ShaftRibbonPanel", "{187856c3-b22f-43dc-8068-5d6adbe4adc5}", "", false);

                    //add controls to the Shaft panel
                    CommandControls partSketchShaftRibbonPanelCtrls;
                    partSketchShaftRibbonPanelCtrls = m_partSketchShaftRibbonPanel.CommandControls;

                    //add the buttons to the ribbon panel

                    CommandControl ShaftCmdBtnCmdCtrl;
                    ShaftCmdBtnCmdCtrl = partSketchShaftRibbonPanelCtrls.AddButton(m_addShaftButton.ButtonDefinition, false, true, "", false);

                }


                // TODO: Add ApplicationAddInServer.Activate implementation.
                // e.g. event initialization, command creation etc.
            }


            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Deactivate()
        {
            // This method is called by Inventor when the AddIn is unloaded.
            // The AddIn will be unloaded either manually by the user or
            // when the Inventor session is terminated

            // TODO: Add ApplicationAddInServer.Deactivate implementation

            // Release objects.
            //release inventor Application object
            Marshal.ReleaseComObject(m_inventorApplication);
            m_inventorApplication = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            
        }

        public void ExecuteCommand(int commandID)
        {
            // Note:this method is now obsolete, you should use the 
            // ControlDefinition functionality for implementing commands.
        }

        public object Automation
        {
            // This property is provided to allow the AddIn to expose an API 
            // of its own to other programs. Typically, this  would be done by
            // implementing the AddIn's API interface in a class and returning 
            // that class object through this property.

            get
            {
                // TODO: Add ApplicationAddInServer.Automation getter implementation
                return null;
            }
        }

        #endregion

    }
}
