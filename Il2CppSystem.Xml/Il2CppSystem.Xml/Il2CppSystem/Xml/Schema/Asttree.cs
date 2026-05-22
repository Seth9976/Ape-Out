using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMS.Internal.Xml.XPath;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F9 RID: 249
	public class Asttree : Object
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x0006BE0C File Offset: 0x0006A00C
		// Note: this type is marked as 'beforefieldinit'.
		static Asttree()
		{
			Il2CppClassPointerStore<Asttree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Asttree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Asttree>.NativeClassPtr);
			Asttree.NativeFieldInfoPtr_fAxisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "fAxisArray");
			Asttree.NativeFieldInfoPtr_xpathexpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "xpathexpr");
			Asttree.NativeFieldInfoPtr_isField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "isField");
			Asttree.NativeFieldInfoPtr_nsmgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "nsmgr");
			Asttree.NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666465);
			Asttree.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666466);
			Asttree.NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666467);
			Asttree.NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666468);
			Asttree.NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666469);
			Asttree.NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666470);
			Asttree.NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666471);
			Asttree.NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666472);
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0006BF2C File Offset: 0x0006A12C
		public unsafe ArrayList SubtreeArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0006BF6C File Offset: 0x0006A16C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407980, RefRangeEnd = 407982, XrefRangeStart = 407979, XrefRangeEnd = 407980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Asttree>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isField;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0006BFD8 File Offset: 0x0006A1D8
		[CallerCount(0)]
		public unsafe static bool IsNameTest(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0006C01C File Offset: 0x0006A21C
		[CallerCount(0)]
		public unsafe static bool IsAttribute(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006C060 File Offset: 0x0006A260
		[CallerCount(0)]
		public unsafe static bool IsDescendantOrSelf(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006C0A4 File Offset: 0x0006A2A4
		[CallerCount(0)]
		public unsafe static bool IsSelf(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006C0E8 File Offset: 0x0006A2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 408047, RefRangeEnd = 408048, XrefRangeStart = 407982, XrefRangeEnd = 408047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isField;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006C14C File Offset: 0x0006A34C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 408051, RefRangeEnd = 408053, XrefRangeStart = 408048, XrefRangeEnd = 408051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetURN(Axis axis, XmlNamespaceManager nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00009437 File Offset: 0x00007637
		public Asttree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x00009440 File Offset: 0x00007640
		public unsafe ArrayList fAxisArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_fAxisArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_fAxisArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0006C1D0 File Offset: 0x0006A3D0
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0000945F File Offset: 0x0000765F
		public unsafe string xpathexpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_xpathexpr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_xpathexpr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0006C1F8 File Offset: 0x0006A3F8
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0000947E File Offset: 0x0000767E
		public unsafe bool isField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_isField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_isField)) = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0006C220 File Offset: 0x0006A420
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x00009499 File Offset: 0x00007699
		public unsafe XmlNamespaceManager nsmgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_nsmgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr_nsmgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_fAxisArray;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_xpathexpr;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr_isField;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr_nsmgr;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0;
	}
}
