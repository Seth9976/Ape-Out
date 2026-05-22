using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F4 RID: 244
	public class AxisElement : Object
	{
		// Token: 0x06001470 RID: 5232 RVA: 0x0006AD28 File Offset: 0x00068F28
		// Note: this type is marked as 'beforefieldinit'.
		static AxisElement()
		{
			Il2CppClassPointerStore<AxisElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AxisElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisElement>.NativeClassPtr);
			AxisElement.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "curNode");
			AxisElement.NativeFieldInfoPtr_rootDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "rootDepth");
			AxisElement.NativeFieldInfoPtr_curDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "curDepth");
			AxisElement.NativeFieldInfoPtr_isMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "isMatch");
			AxisElement.NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666435);
			AxisElement.NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666436);
			AxisElement.NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666437);
			AxisElement.NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666438);
			AxisElement.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666439);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0006AE0C File Offset: 0x0006900C
		public unsafe DoubleLinkAxis CurNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0006AE4C File Offset: 0x0006904C
		[CallerCount(0)]
		public unsafe AxisElement(DoubleLinkAxis node, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0006AEA8 File Offset: 0x000690A8
		[CallerCount(0)]
		public unsafe void SetDepth(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0006AEE8 File Offset: 0x000690E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407879, XrefRangeEnd = 407880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToParent(int depth, ForwardAxis parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0006AF38 File Offset: 0x00069138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407880, XrefRangeEnd = 407882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToChild(string name, string URN, int depth, ForwardAxis parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0000921B File Offset: 0x0000741B
		public AxisElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0006AFB8 File Offset: 0x000691B8
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x00009224 File Offset: 0x00007424
		public unsafe DoubleLinkAxis curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0006AFE8 File Offset: 0x000691E8
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x00009243 File Offset: 0x00007443
		public unsafe int rootDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_rootDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_rootDepth)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0006B010 File Offset: 0x00069210
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0000925E File Offset: 0x0000745E
		public unsafe int curDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curDepth)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0006B038 File Offset: 0x00069238
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x00009279 File Offset: 0x00007479
		public unsafe bool isMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_isMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_isMatch)) = value;
			}
		}

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr_rootDepth;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr_curDepth;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeFieldInfoPtr_isMatch;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0;
	}
}
