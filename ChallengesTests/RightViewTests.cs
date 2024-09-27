using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class RightViewTests
    {
        [Fact]
        public void RightView_MultipleNodes_ShouldReturnCorrectOutput()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new TNode(2);
            tree.Root.Left = new TNode(3);
            tree.Root.Right = new TNode(5);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Right.Right = new TNode(6);
            tree.Root.Left.Left.Right = new TNode(7);

            // Capture console output
            var output = new StringWriter();
            Console.SetOut(output);
            tree.PrintRightView();

            Assert.Equal("2 5 6 7 ", output.ToString());
        }

        [Fact]
        public void RightView_RightOnlyNodes_ShouldReturnCorrectOutput()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Right = new TNode(2);
            tree.Root.Right.Right = new TNode(3);

            var output = new StringWriter();
            Console.SetOut(output);
            tree.PrintRightView();

            Assert.Equal("1 2 3 ", output.ToString());
        }
    }

}
