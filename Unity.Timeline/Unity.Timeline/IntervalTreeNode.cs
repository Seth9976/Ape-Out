using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct IntervalTreeNode
	{
		// Token: 0x0600033A RID: 826 RVA: 0x000112E0 File Offset: 0x0000F4E0
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalTreeNode()
		{
			Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IntervalTreeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr);
			IntervalTreeNode.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "center");
			IntervalTreeNode.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "first");
			IntervalTreeNode.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "last");
			IntervalTreeNode.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "left");
			IntervalTreeNode.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "right");
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003033 File Offset: 0x00001233
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, ref this));
		}

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400029C RID: 668
		[FieldOffset(0)]
		public long center;

		// Token: 0x0400029D RID: 669
		[FieldOffset(8)]
		public int first;

		// Token: 0x0400029E RID: 670
		[FieldOffset(12)]
		public int last;

		// Token: 0x0400029F RID: 671
		[FieldOffset(16)]
		public int left;

		// Token: 0x040002A0 RID: 672
		[FieldOffset(20)]
		public int right;
	}
}
