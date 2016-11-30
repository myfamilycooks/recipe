using System.Collections.Generic;
using System.Linq;
using Recipe.Server.Entities;

namespace Recipe.Server.Business
{
    public interface IRecipeService
    {
        IEnumerable<RecipeHeader> GetRecipeHeaders();
        RecipeDetail GetRecipeDetail(int recipeId);
    }

    public class RecipeService : IRecipeService
    {
        private readonly List<RecipeDetail> staticRecipeRepository;

        public RecipeService()
        {
            this.staticRecipeRepository = new List<RecipeDetail>
            {
                new RecipeDetail
                {
                    RecipeId = 1,
                    Name = "Bloomin' Onion",
                    Description = @"Combine all of the dip ingredients in a bowl, cover and refrigerate.
                    Slice the onion (see below). Whisk the flour, cayenne, paprika, thyme, oregano, cumin and 1/2 teaspoon black pepper in a bowl. In a small deep bowl, whisk the eggs, milk and 1 cup water.
                    Place the onion in a separate bowl, cut-side up, and pour all of the flour mixture on top. Cover the bowl with a plate, then shake back and forth to distribute the flour. Check to make sure the onion is fully coated, especially between the ""petals."" Lift the onion by the core, turn over and pat off the excess flour; reserve the bowl of flour.
                    Using a slotted spoon, fully submerge the onion in the egg mixture(spoon on top, if necessary).Remove and let the excess egg drip off, then repeat the flouring process.Refrigerate the onion while you heat the oil.
                    Heat the oil in a large deep pot over medium-high heat until a deep-fry thermometer registers 400 degrees.Pat off excess flour from the onion.Using a wire skimmer, carefully lower the onion into the oil, cut - side down.Adjust the heat so the oil temperature stays close to 350 degrees.Fry about 3 minutes, then turn the onion over and cook until golden, about 3 more minutes; drain on paper towels. Season with salt and serve with the dip.",
                    ImageUrl ="http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2009/11/4/3/FNM_120109-Copy-That-003_s4x3.jpg.rend.snigalleryslide.jpeg"
                },
                new RecipeDetail
                {
                    RecipeId = 2,
                    Name = "Choclate Mouse Cake",
                    Description = @"Make the cake: Prepare the cake mix as the label directs for a 9-by-13-inch cake. Bake; cool slightly in the pan, then invert onto a rack to cool completely.
                    Clean out the cake pan and line it with plastic wrap. Cut the cake in half lengthwise, then in thirds crosswise to make 6 rectangles. Using a serrated knife, slice each rectangle in half to make two layers. Arrange half of the pieces snugly in the cake pan. Crumble the remaining pieces and press tightly into 6 small balls; arrange 1 cake ball in the center of each cake rectangle in the pan.
                    Make the mousse: Heat the chocolate, butter, coffee and 1/4 cup water in a heatproof bowl set over a saucepan of simmering water (do not let the bowl touch the water), stirring, until melted. Remove the bowl from the pan; stir until cool. Reserve the simmering water. Fill a large bowl with ice water.
                    Whisk the egg yolks, 1 1/2 cups sugar and 2 tablespoons water in a separate large heatproof bowl. Set the bowl over the saucepan of simmering water and whisk until pale yellow, 6 to 8 minutes. Add the chocolate-coffee mixture and the vanilla and whisk until combined, about 2 minutes. Remove the bowl from the pan and set in the bowl of ice water; whisk until slightly cool but not thick, about 4 minutes.
                    Beat the egg whites and salt in a bowl with a mixer until foamy. Add 2 tablespoons sugar and beat until almost stiff; gently fold into the chocolate-yolk mixture to make a dark chocolate mousse. Spread 5 cups over the cake and cake balls. Freeze until firm on top, about 30 minutes.
                    Beat the heavy cream and the remaining 4 tablespoons sugar until soft peaks form; fold into the remaining mousse. Remove the cake from the freezer; spread with the light chocolate mousse, cover with plastic wrap and freeze until firm, at least 6 hours or overnight.
                    Make the chocolate shell: Stir the chocolate, heavy cream and 4 tablespoons corn syrup in a heatproof bowl set over a saucepan of simmering water (do not let the bowl touch the water) until melted. A spoonful at a time, spread half of the shell mixture over the frozen mousse. Return to the freezer.
                    Make the chocolate sauce: Add the remaining 1 tablespoon corn syrup and the butter to the remaining chocolate shell mixture. Microwave 30 seconds, then stir until glossy.
                    To serve the cake, beat the heavy cream with a mixer until foamy. Add the sugar and beat until soft peaks form. Remove the cake from the freezer; invert onto a baking sheet and unmold, then invert again onto a platter, chocolate shell-side up.
                    Cut the cake in half lengthwise using a warm knife, then cut into thirds crosswise to make 6 rectangles; cut each rectangle in half diagonally to make 2 triangles. Top each triangle with whipped cream, ice cream and the prepared chocolate sauce.",
                    ImageUrl = "http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2012/1/24/1/FNM_030112-Copy-That-001_s4x3.jpg.rend.sni12col.landscape.jpeg"
                },
                new RecipeDetail
                {
                    RecipeId = 3,
                    Name = "Barbecue Chicken Pizza",
                    Description = @"Brush a large bowl with olive oil. Shape the pizza dough into a ball, add it to the bowl and turn to coat with the oil. Cover tightly with plastic wrap and set aside in a warm place, 30 to 40 minutes.
                    Position racks in the upper third and middle of the oven. Place a pizza stone or inverted baking sheet on the top rack and preheat the oven to 425 degrees F for at least 30 minutes.
                    Meanwhile, lay out a sheet of parchment paper and brush with olive oil. Transfer the ball of dough to the parchment and roll it out into a 10-inch round, stretching it with your hands as needed. Lightly brush the dough with olive oil, cover with another piece of parchment and set aside to let rise slightly, about 30 minutes.
                    While the dough rises, mix 2 tablespoons barbecue sauce and 1 teaspoon olive oil in a small bowl. Put the chicken in a baking dish, season with salt and pepper and brush with the barbecue sauce mixture. Bake on the middle oven rack until cooked through, about 20 minutes. Let cool, then cut into 1/2-inch cubes.
                    Uncover the dough and spread with the remaining 1/3 cup barbecue sauce, leaving a 3/4-inch border. Top with the chicken, gouda, mozzarella and red onion. Slide the pizza (on the parchment) onto a pizza peel or another inverted baking sheet, then slide onto the hot stone or baking sheet; bake until the cheese melts and the crust is golden, 20 to 25 minutes. Sprinkle with cilantro.",
                    ImageUrl ="http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2012/2/28/1/FNM_040112-Copy-That-002_s4x3.jpg.rend.sni12col.landscape.jpeg"
                },
                new RecipeDetail
                {
                    RecipeId = 4,
                    Name = "Cheesecake Pancakes",
                    ImageUrl = "http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2011/4/5/3/FNM-050111_Cover-0022_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Mix the strawberries, jam and 2 tablespoons warm water in a bowl; set aside. Preheat the oven to 200 degrees F.
                    Pulse the flour, buttermilk, egg, vegetable oil, granulated sugar, baking powder, baking soda and salt in a blender until smooth. Transfer to a bowl and stir in the cheesecake pieces, keeping them whole.
                    Coat a large nonstick skillet or griddle with cooking spray and heat over medium heat. Working in batches, pour about 1/4 cup batter into the skillet for each pancake. Cook until bubbly on top, about 4 minutes, then flip and cook until the other side is golden brown, about 2 more minutes. Transfer the finished pancakes to a baking sheet and keep warm in the oven. Serve the pancakes topped with the strawberry sauce; top with butter, confectioners' sugar or whipped cream, if desired."

                },
                new RecipeDetail
                {
                    RecipeId = 5,
                    Name = "Breadsticks",
                    Description = @"Make the dough: Place 1/4 cup warm water in the bowl of a mixer; sprinkle in the yeast and set aside until foamy, about 5 minutes. Add the flour, butter, sugar, fine salt and 1 1/4 cups plus 2 tablespoons warm water; mix with the paddle attachment until a slightly sticky dough forms, 5 minutes.
                    Knead the dough by hand on a floured surface until very smooth and soft, 3 minutes. Roll into a 2-foot-long log; cut into 16 1 1/2-inch-long pieces. Knead each piece slightly and shape into a 7-inch-long breadstick; arrange 2 inches apart on a parchment-lined baking sheet. Cover with a cloth; let rise in a warm spot until almost doubled, about 45 minutes.
                    Preheat the oven to 400 degrees. Make the topping: Brush the breadsticks with 1 1/2 tablespoons of the butter and sprinkle with 1/4 teaspoon kosher salt. Bake until lightly golden, about 15 minutes. Meanwhile, combine the remaining 1/4 teaspoon salt with the garlic powder and oregano. Brush the warm breadsticks with the remaining 1 1/2 tablespoons melted butter and sprinkle with the flavored salt.",
                    ImageUrl = "http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2009/4/15/0/FNM060109CopyThat002_breadstick_s4x3.jpg.rend.sni12col.landscape.jpeg"
                    
                },
                new RecipeDetail
                {
                    RecipeId = 6,
                    Name = "Orange Milkshake",
                    ImageUrl ="http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2010/3/25/0/FNM_050110-Copy-That-001_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Mix the orange juice concentrate with 1 cup water in a large measuring cup or bowl. (You can also use 2 cups orange juice instead of this mixture.)
                    Transfer the orange juice to a blender. Add the milk, vanilla, both sugars and 1 cup ice and blend until smooth and frothy. Divide among 4 chilled glasses."
                },
                new RecipeDetail
                {
                    RecipeId = 7,
                    Name = "Cinnamon Buns",
                    ImageUrl = "http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2009/9/25/1/FNM-110109-Copy-That-003_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Make the dough: Warm the milk in a medium saucepan over low heat until it reaches about 100. Remove from the heat and sprinkle in the yeast and 1/4 teaspoon sugar (don't stir). Set aside until foamy, 5 minutes. Whisk in the melted butter, egg yolk and vanilla.
                    Whisk the flour, the remaining 1/4 cup sugar, the salt and nutmeg in the bowl of a stand mixer. Make a well in the center and pour in the yeast mixture. Mix on low speed with the dough hook until thick and slightly sticky. Knead on medium speed until the dough gathers around the hook, 6 minutes. (Add up to 2 more tablespoons flour if necessary.)
                    Remove the dough and shape into a ball. Butter the mixer bowl and return the dough to the bowl, turning to coat with butter. Cover with plastic wrap and let rise until doubled, 1 hour 15 minutes.
                    See how to form these Cinnamon Buns
                    Roll out the dough, fill and cut into buns (see instructions below). Butter a 9-by-13-inch baking pan; place the buns cut-side down in the pan, leaving space between each. Cover with plastic wrap and let rise until doubled, 40 minutes. Preheat the oven to 325.
                    Bake the buns until golden brown, about 35 minutes. Cool in the pan 15 minutes. Meanwhile, make the glaze: Sift the confectioners' sugar into a bowl, then whisk in the cream and melted butter. Transfer the buns to a rack and spoon the glaze on top while still warm."
                },
                new RecipeDetail
                {
                    RecipeId = 8,
                    Name = "Swedish Meatballs",
                    ImageUrl ="http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2011/8/29/3/FNM_100111-Copy-That-002-0_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Make the meatballs: Put the breadcrumbs in a large bowl. Heat the butter in a skillet over medium heat. Add the onion, garlic, allspice, 2 teaspoons salt and 1/4 teaspoon white pepper and cook, stirring, until soft, about 5 minutes. Add the milk and Worcestershire sauce and bring to a simmer. Pour the milk mixture over the breadcrumbs and stir to make a thick paste; let cool. Add the beef, pork, egg and egg white to the bowl and mix until combined.
                    Brush a baking sheet with vegetable oil. Roll the meat into 1-inch balls and arrange on the prepared baking sheet. Cover with plastic wrap and refrigerate at least 1 hour.
                    Preheat the oven to 400 degrees F. Bake the meatballs until cooked through, about 20 minutes.
                    Make the gravy: Melt the butter in a large skillet over medium heat. Add the flour and cook, whisking, until smooth. Whisk in the beef broth and Worcestershire sauce and bring to a simmer. Add the cream and meatballs. Reduce the heat to medium low and simmer until the gravy thickens, about 10 minutes. Season with salt and black pepper. Transfer to a serving dish; sprinkle with the parsley and serve with lingonberry jam, if desired."
                },
                new RecipeDetail
                {
                    RecipeId = 9,
                    Name = "Broccoli-Chedar Soup",
                    ImageUrl = "http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2009/12/13/0/FNM_010110-Copy-That-002_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Melt the butter in a large Dutch oven or pot over medium heat. Add the onion and cook until tender, about 5 minutes. Whisk in the flour and cook until golden, 3 to 4 minutes, then gradually whisk in the half-and-half until smooth. Add the chicken broth, bay leaves and nutmeg, then season with salt and pepper and bring to a simmer. Reduce the heat to medium-low and cook, uncovered, until thickened, about 20 minutes.
                    Meanwhile, prepare the bread bowls: Using a sharp knife, cut a circle into the top of each loaf, leaving a 1-inch border all around. Remove the bread top, then hollow out the middle with a fork or your fingers, leaving a thick bread shell.
                    Add the broccoli and carrot to the broth mixture and simmer until tender, about 20 minutes. Discard the bay leaves. Puree the soup in batches in a blender until smooth; you'll still have flecks of carrot and broccoli. Return to the pot. (Or puree the soup in the pot with an immersion blender.)
                    Add the cheese to the soup and whisk over medium heat until melted. Add up to 3/4 cup water if the soup is too thick. Ladle into the bread bowls and garnish with cheese."
                },
                new RecipeDetail
                {
                    RecipeId = 10,
                    Name = "Maple-Butter Blondies",
                    ImageUrl ="http://foodnetwork.sndimg.com/content/dam/images/food/fullset/2010/1/21/2/FNM_030110-Copy-That-003_s4x3.jpg.rend.sni12col.landscape.jpeg",
                    Description = @"Make the blondies: Preheat the oven to 350 degrees F. Line a 9-by-13-inch baking pan with foil, leaving an overhang on two sides; butter the foil. Pulse 1/2 cup walnuts in a food processor until almost fine (do not overprocess). Whisk the ground nuts, flour, baking powder, baking soda and salt in a medium bowl.
                    Beat 10 tablespoons butter and the brown sugar with a mixer on medium speed until fluffy, about 2 minutes. Beat in the eggs, one at a time, scraping down the bowl with a rubber spatula. Beat in the vanilla. Gradually beat in the dry ingredients until just combined. Fold in the white chocolate and the remaining 1/2 cup walnuts.
                    Spread the batter in the prepared pan and bake until the blondies are light brown around the edges and spring back when pressed, about 30 minutes. Cool slightly on a rack.
                    Meanwhile, make the topping: Place the maple syrup and butter in a small saucepan over medium heat and cook until the mixture bubbles and thickens, swirling the pan, about 6 minutes. Add the cream and continue to cook until the mixture is the consistency of caramel.
                    Use the foil to lift the blondies out of the pan, then cut into large bars. Serve warm topped with ice cream, the maple-butter sauce and the walnuts."
                }
            };
        }

        public IEnumerable<RecipeHeader> GetRecipeHeaders()
        {
            var recipeHeaders = this.staticRecipeRepository
                .Select(x => new RecipeHeader
                {
                    RecipeId = x.RecipeId,
                    Name = x.Name
                });

            return recipeHeaders.ToList();
        }

        public RecipeDetail GetRecipeDetail(int recipeId)
        {
            var recipe = this.staticRecipeRepository
                .FirstOrDefault(x => x.RecipeId == recipeId);

            return recipe;
        }
    }
}
