using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public interface IInspectTubuleControl
    {
        void RunRecipe(RecipeModel recipeModel, Bitmap bitmap, int triggerTime, bool isTest);
        void SetChildViewModel(RecipeEnum imageSource, object viewModel);
    }
}
