using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Dialog { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/custom-dialogs",
                FileName = "CustomDialogs.razor"
            },
            new Sample
            {
                Name = "Modal",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/modal",
                FileName = "Modal.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/draggable",
                FileName = "Draggable.razor"
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Type = SampleType.Updated,
                Directory = "Popups/Dialog",
                Url = "dialog/resizable",
                FileName = "Resizable.razor"
            },
            new Sample
            {
                Name = "Positioning",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/positioning",
                FileName = "Positioning.razor"
            },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/multiple-dialogs",
                FileName = "MultipleDialogs.razor"
            }
        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "HTML Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/html-template",
                FileName = "HtmlTemplate.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/api",
                FileName = "Api.razor"
            }
        };   
    }
}
