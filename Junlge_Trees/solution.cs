
https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017/MasterExam/Day1/1.%20Jungle%20trees/README.md

// Description
// Steve is tired of people. He is going to live in the jungle.

// His preferred way of moving is by jumping from one tree to another.
//  There will be N trees in the jungle. Each tree will have X coordinate and height H. Steve will not be able to jump between trees whose X coordinate difference is more than MJ or height difference is more than MH. He will need your help to get from the leftmost tree (lowest X coordinate) to rightmost one (highest X coordinate).
//   Write a program which finds the minimal amount of jumps needed or prints -1 if it is impossible.

using System;
using System.Collections.Generic;

namespace JungleTrees
{
	struct JungleTree
	{
		public int X;
		public int Height;
	}

	class Program
	{
		static void Main()
		{
			var strs = Console.ReadLine().Split(' ');
			var n = int.Parse(strs[0]);
			var maxJumpDistance = int.Parse(strs[1]);
			var maxHeightDifference = int.Parse(strs[2]);

			var trees = new JungleTree[n];
			for(int i = 0; i < n; ++i)
			{
				strs = Console.ReadLine().Split(' ');
				trees[i].X = int.Parse(strs[0]);
				trees[i].Height = int.Parse(strs[1]);
			}

			Array.Sort(trees, (x, y) => x.X - y.X);

			var minJumps = new int[n];
			for(int i = 0; i < n; ++i)
			{
				minJumps[i] = -1;
			}

			minJumps[0] = 0;

			var q = new Queue<int>();
			q.Enqueue(0);

			while(q.Count > 0)
			{
				var from = q.Dequeue();

				for(int to = 0; to < n; ++to)
				{
					if(minJumps[to] < 0
							&& Math.Abs(trees[from].Height - trees[to].Height) <= maxHeightDifference
							&& Math.Abs(trees[from].X - trees[to].X) <= maxJumpDistance)
					{
						minJumps[to] = minJumps[from] + 1;
						q.Enqueue(to);
					}
				}
			}

			Console.WriteLine(minJumps[n - 1]);
		}
	}
}