using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMS.Internal.Xml.Cache
{
	// Token: 0x02000012 RID: 18
	public sealed class XPathNodeRef : ValueType
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00017F34 File Offset: 0x00016134
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeRef()
		{
			Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr);
			XPathNodeRef.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "page");
			XPathNodeRef.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "idx");
			XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663429);
			XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663430);
			XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663431);
			XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663432);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00017FDC File Offset: 0x000161DC
		[CallerCount(0)]
		public unsafe XPathNodeRef(Il2CppReferenceArray<XPathNode> page, int idx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0001803C File Offset: 0x0001623C
		public unsafe Il2CppReferenceArray<XPathNode> Page
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00018080 File Offset: 0x00016280
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000180C4 File Offset: 0x000162C4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002782 File Offset: 0x00000982
		public XPathNodeRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000278B File Offset: 0x0000098B
		public XPathNodeRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00018108 File Offset: 0x00016308
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe Il2CppReferenceArray<XPathNode> page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_page);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00018138 File Offset: 0x00016338
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe int idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_idx)) = value;
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_idx;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
