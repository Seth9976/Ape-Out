using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000157 RID: 343
	public class Node : Object
	{
		// Token: 0x06002930 RID: 10544 RVA: 0x000A6358 File Offset: 0x000A4558
		// Note: this type is marked as 'beforefieldinit'.
		static Node()
		{
			Il2CppClassPointerStore<Node>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Node");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Node>.NativeClassPtr);
			Node.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "pos");
			Node.NativeFieldInfoPtr_cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "cell");
			Node.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "parent");
			Node.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "score");
			Node.NativeFieldInfoPtr_cleanScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "cleanScore");
			Node.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Node>.NativeClassPtr, "index");
			Node.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Node>.NativeClassPtr, 100666560);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000A6414 File Offset: 0x000A4614
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Node()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Node>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Node.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0001CB36 File Offset: 0x0001AD36
		public Node(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x000A6450 File Offset: 0x000A4650
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x0001CB3F File Offset: 0x0001AD3F
		public unsafe Intv2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x000A6478 File Offset: 0x000A4678
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x0001CB5A File Offset: 0x0001AD5A
		public unsafe PFCell cell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_cell);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_cell)) = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000A64A0 File Offset: 0x000A46A0
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x0001CB75 File Offset: 0x0001AD75
		public unsafe Node parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000A64D0 File Offset: 0x000A46D0
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x0001CB94 File Offset: 0x0001AD94
		public unsafe float score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000A64F8 File Offset: 0x000A46F8
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x0001CBAF File Offset: 0x0001ADAF
		public unsafe float cleanScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_cleanScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_cleanScore)) = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x000A6520 File Offset: 0x000A4720
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x0001CBCA File Offset: 0x0001ADCA
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Node.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr_cell;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeFieldInfoPtr_cleanScore;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
