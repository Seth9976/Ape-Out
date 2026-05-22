using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000066 RID: 102
	public sealed class RegexTree : Object
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0002C73C File Offset: 0x0002A93C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexTree()
		{
			Il2CppClassPointerStore<RegexTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexTree>.NativeClassPtr);
			RegexTree.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_root");
			RegexTree.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_caps");
			RegexTree.NativeFieldInfoPtr__capnumlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capnumlist");
			RegexTree.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capnames");
			RegexTree.NativeFieldInfoPtr__capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capslist");
			RegexTree.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_options");
			RegexTree.NativeFieldInfoPtr__captop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_captop");
			RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, 100664381);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0002C80C File Offset: 0x0002AA0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372303, RefRangeEnd = 372304, XrefRangeStart = 372303, XrefRangeEnd = 372303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexTree(RegexNode root, Hashtable caps, Il2CppStructArray<int> capnumlist, int captop, Hashtable capnames, Il2CppStringArray capslist, RegexOptions opts)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexTree>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnumlist);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref captop;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capslist);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00004C79 File Offset: 0x00002E79
		public RegexTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0002C8C0 File Offset: 0x0002AAC0
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00004C82 File Offset: 0x00002E82
		public unsafe RegexNode _root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0002C8F0 File Offset: 0x0002AAF0
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00004CA1 File Offset: 0x00002EA1
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0002C920 File Offset: 0x0002AB20
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public unsafe Il2CppStructArray<int> _capnumlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnumlist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnumlist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0002C950 File Offset: 0x0002AB50
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00004CDF File Offset: 0x00002EDF
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0002C980 File Offset: 0x0002AB80
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00004CFE File Offset: 0x00002EFE
		public unsafe Il2CppStringArray _capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0002C9B0 File Offset: 0x0002ABB0
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00004D1D File Offset: 0x00002F1D
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00004D38 File Offset: 0x00002F38
		public unsafe int _captop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__captop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__captop)) = value;
			}
		}

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr__capnumlist;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr__capslist;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr__captop;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0;
	}
}
