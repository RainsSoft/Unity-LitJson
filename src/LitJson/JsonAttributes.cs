using System;
namespace LitJson
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
	public class IgnoreAttribute : Attribute
	{
	}
}