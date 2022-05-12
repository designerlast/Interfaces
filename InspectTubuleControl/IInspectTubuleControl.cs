using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public interface IInspectTubuleControl
    {
        void RunRecipe(RecipeModel recipeModel);
        void SetChildViewModel(RecipeEnum imageSource, object viewModel);
    }
}
