using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
	public class BinaryTree
	{
		public TreeNode Root;

		List<int> preOrder = new List<int>();
		List<int> inOrder = new List<int>();

		public BinaryTree()
		{

		}
		public BinaryTree(TreeNode node)
		{
			Root = node;
		}
		public List<int> PreOrder()
		{
			PreOrder(Root);
			return preOrder;
		}

		private List<int> PreOrder(TreeNode root)
		{
			try
			{
				preOrder.Add(root.value);
			}
			catch (Exception)
			{
				throw;
			}
			if (root.left != null)
			{
				PreOrder(root.left);
			}
			if (root.right != null)
			{
				PreOrder(root.right);
			}
			return preOrder;
		}

		public List<int> InOrder()
		{
			InOrder(Root);
			return inOrder;
		}
		private List<int> InOrder(TreeNode root)
		{
			if (root.left != null)
			{
				InOrder(root.left);
			}
			try
			{
				inOrder.Add(root.value);
			}
			catch (Exception)
			{
				throw;
			}
			if (root.right != null)
			{
				InOrder(root.right);
			}
			return inOrder;
		}

	}
}
