/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/17/2018
 * Time: 1:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;

namespace BigInt
{
	/// <summary>
	/// Description of clsBigInt.
	/// </summary>
	public class clsBigInt
	{
		private string sValue;
		public int signum = 1;
		public string Value
		{
			get
			{
				return sValue;
			}
			set
			{
				sValue = value;				
			}
		}
		public clsBigInt()
		{
			sValue = "0";
		}
		
	
		public clsBigInt Plus(clsBigInt a, clsBigInt b)
		{
			clsBigInt c = new clsBigInt();
			if(a.signum != b.signum)
			{
				int compare = CompareABS(a, b);
				if(compare == 0)
				{
					c.sValue  ="0";
				}
	
			}
			else 
			{
				int compare = CompareABS(a, b);
				if(compare == 0)
				{
					int t = 0;
					for(int i = a.sValue.Length - 1; i >= 0; i++)
					{
						int temp = (int)a.sValue[i]+ (int)b.sValue[i] + t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "1";
					}
				}
				if(compare == 1)
				{
					int t = 0;
					for(int i = a.sValue.Length - 1; i >= 0; i++)
					{
						int temp = int.Parse(a.sValue[i].ToString())+ int.Parse(b.sValue[i].ToString()) + t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "1";
					}
				}
				if(compare == -1)
				{
					int t = 0;
					for(int i = b.sValue.Length - 1; i >= 0; i++)
					{
						int temp = (int)a.sValue[i]+ (int)b.sValue[i] + t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "1";
					}
				}
				
			}
			return c;
		}
		public clsBigInt Subtract(clsBigInt a, clsBigInt b)
		{
			clsBigInt c = new clsBigInt();
			if(a.signum != b.signum)
			{
				int compare = CompareABS(a, b);
				if(compare == 0)
				{
					c.sValue  ="0";
				}
	
			}
			else 
			{
				int compare = CompareABS(a, b);
				if(compare == 0)
				{
					int t = 0;
					for(int i = a.sValue.Length - 1; i >= 0; i++)
					{
						int temp = (int)a.sValue[i]- (int)b.sValue[i] - t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "-1";
					}
				}
				if(compare == 1)
				{
					int t = 0;
					for(int i = a.sValue.Length - 1; i >= 0; i++)
					{
						int temp = int.Parse(a.sValue[i].ToString())+ int.Parse(b.sValue[i].ToString()) + t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "1";
					}
				}
				if(compare == -1)
				{
					int t = 0;
					for(int i = b.sValue.Length - 1; i >= 0; i++)
					{
						int temp = (int)a.sValue[i]+ (int)b.sValue[i] + t;
						t = temp/10;
						temp = temp%10;
						c.sValue += temp;
					}
					if(t == 1)
					{
						c.sValue += "1";
					}
				}
				
			}
			return c;
		}
		public int CompareABS(clsBigInt a, clsBigInt b)
		{
			if(a.sValue.Length > b.sValue.Length)
			{
				return 1;
			}
			if(a.sValue.Length < b.sValue.Length)
			{	
				return -1;
			}
			for(int i = 0; i < a.sValue.Length; i++)
			{
				if(a.sValue[i] > b.sValue[i])
				{
					return 1;
				}
				if (a.sValue[i] < b.sValue[i])
				{
					return -1;
				}
			}
			return 0;
		}
		
		
	}
}
