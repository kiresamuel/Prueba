﻿#pragma checksum "C:\Desarrollo\PruebaUWP\PruebaUWP\OpcionSeleccionada.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5053A49E6A03CA95222454933AC8D97C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaUWP
{
    partial class OpcionSeleccionada : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class OpcionSeleccionada_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IOpcionSeleccionada_Bindings
        {
            private global::PruebaUWP.OpcionSeleccionada dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj9TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj13TextDisabled = false;
            private static bool isobj14TextDisabled = false;
            private static bool isobj15TextDisabled = false;
            private static bool isobj16TextDisabled = false;

            private OpcionSeleccionada_obj1_BindingsTracking bindingsTracking;

            public OpcionSeleccionada_obj1_Bindings()
            {
                this.bindingsTracking = new OpcionSeleccionada_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 126 && columnNumber == 49)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 110 && columnNumber == 55)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 113 && columnNumber == 55)
                {
                    isobj13TextDisabled = true;
                }
                else if (lineNumber == 116 && columnNumber == 55)
                {
                    isobj14TextDisabled = true;
                }
                else if (lineNumber == 119 && columnNumber == 55)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 122 && columnNumber == 55)
                {
                    isobj16TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // OpcionSeleccionada.xaml line 126
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // OpcionSeleccionada.xaml line 110
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // OpcionSeleccionada.xaml line 113
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14: // OpcionSeleccionada.xaml line 116
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15: // OpcionSeleccionada.xaml line 119
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 16: // OpcionSeleccionada.xaml line 122
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IOpcionSeleccionada_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PruebaUWP.OpcionSeleccionada)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PruebaUWP.OpcionSeleccionada obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas(obj.DatosPeliculas, phase);
                    }
                }
            }
            private void Update_DatosPeliculas(global::PruebaUWP.ViewModels.DatosPelicula_VM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_DatosPeliculas(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas_Pelicula(obj.Pelicula, phase);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula(global::PruebaUWP.Models.GrupoPeliculaModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas_Pelicula_External(obj.External, phase);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External(global::PruebaUWP.Models.ExternalModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote(obj.Gracenote, phase);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote(global::PruebaUWP.Models.GracenoteModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Description(obj.Description, phase);
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Title(obj.Title, phase);
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Genres(obj.Genres, phase);
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Publishyear(obj.Publishyear, phase);
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Rating(obj.Rating, phase);
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Duration(obj.Duration, phase);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 126
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 110
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Genres(global::System.String[] obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_DatosPeliculas_Pelicula_External_Gracenote_Genres_I0(obj[0], phase);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Genres_I0(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 113
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj, null);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Publishyear(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 116
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Rating(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 119
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj, null);
                    }
                }
            }
            private void Update_DatosPeliculas_Pelicula_External_Gracenote_Duration(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // OpcionSeleccionada.xaml line 122
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class OpcionSeleccionada_obj1_BindingsTracking
            {
                private global::System.WeakReference<OpcionSeleccionada_obj1_Bindings> weakRefToBindingObj; 

                public OpcionSeleccionada_obj1_BindingsTracking(OpcionSeleccionada_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<OpcionSeleccionada_obj1_Bindings>(obj);
                }

                public OpcionSeleccionada_obj1_Bindings TryGetBindingObject()
                {
                    OpcionSeleccionada_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_DatosPeliculas(null);
                }

                public void PropertyChanged_DatosPeliculas(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OpcionSeleccionada_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::PruebaUWP.ViewModels.DatosPelicula_VM obj = sender as global::PruebaUWP.ViewModels.DatosPelicula_VM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_DatosPeliculas_Pelicula(obj.Pelicula, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Pelicula":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_DatosPeliculas_Pelicula(obj.Pelicula, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::PruebaUWP.ViewModels.DatosPelicula_VM cache_DatosPeliculas = null;
                public void UpdateChildListeners_DatosPeliculas(global::PruebaUWP.ViewModels.DatosPelicula_VM obj)
                {
                    if (obj != cache_DatosPeliculas)
                    {
                        if (cache_DatosPeliculas != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_DatosPeliculas).PropertyChanged -= PropertyChanged_DatosPeliculas;
                            cache_DatosPeliculas = null;
                        }
                        if (obj != null)
                        {
                            cache_DatosPeliculas = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_DatosPeliculas;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // OpcionSeleccionada.xaml line 68
                {
                    this.Scroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 3: // OpcionSeleccionada.xaml line 173
                {
                    this.LstListado1 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4: // OpcionSeleccionada.xaml line 196
                {
                    this.LstListado2 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7: // OpcionSeleccionada.xaml line 94
                {
                    this.ImgBackgroud = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // OpcionSeleccionada.xaml line 96
                {
                    this.TxtTitulo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // OpcionSeleccionada.xaml line 126
                {
                    this.TxtDesc = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // OpcionSeleccionada.xaml line 130
                {
                    this.TxtNota = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // OpcionSeleccionada.xaml line 149
                {
                    this.TxtNota2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // OpcionSeleccionada.xaml line 110
                {
                    this.TxtDatos1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // OpcionSeleccionada.xaml line 113
                {
                    this.TxtDatos2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // OpcionSeleccionada.xaml line 116
                {
                    this.TxtDatos3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // OpcionSeleccionada.xaml line 119
                {
                    this.TxtDatos4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // OpcionSeleccionada.xaml line 122
                {
                    this.TxtDatos5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // OpcionSeleccionada.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    OpcionSeleccionada_obj1_Bindings bindings = new OpcionSeleccionada_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

