using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F5 RID: 245
	public class AxisStack : Object
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x0006B060 File Offset: 0x00069260
		// Note: this type is marked as 'beforefieldinit'.
		static AxisStack()
		{
			Il2CppClassPointerStore<AxisStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AxisStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisStack>.NativeClassPtr);
			AxisStack.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "stack");
			AxisStack.NativeFieldInfoPtr_subtree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "subtree");
			AxisStack.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "parent");
			AxisStack.NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666440);
			AxisStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666441);
			AxisStack.NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666442);
			AxisStack.NativeMethodInfoPtr_Push_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666443);
			AxisStack.NativeMethodInfoPtr_Pop_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666444);
			AxisStack.NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666445);
			AxisStack.NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666446);
			AxisStack.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666447);
			AxisStack.NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666448);
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0006B180 File Offset: 0x00069380
		public unsafe ForwardAxis Subtree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ForwardAxis>(intPtr3) : null;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0006B1C0 File Offset: 0x000693C0
		public unsafe int Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0006B1FC File Offset: 0x000693FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407882, XrefRangeEnd = 407887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisStack(ForwardAxis faxis, ActiveAxis parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(faxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0006B25C File Offset: 0x0006945C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407891, RefRangeEnd = 407894, XrefRangeStart = 407887, XrefRangeEnd = 407891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Push_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0006B29C File Offset: 0x0006949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407894, XrefRangeEnd = 407895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Pop_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0006B2D0 File Offset: 0x000694D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407895, RefRangeEnd = 407898, XrefRangeStart = 407895, XrefRangeEnd = 407895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equal(string thisname, string thisURN, string name, string URN)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(thisURN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0006B348 File Offset: 0x00069548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407905, RefRangeEnd = 407906, XrefRangeStart = 407898, XrefRangeEnd = 407905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToParent(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0006B3AC File Offset: 0x000695AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407917, RefRangeEnd = 407918, XrefRangeStart = 407906, XrefRangeEnd = 407917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToChild(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0006B41C File Offset: 0x0006961C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407922, RefRangeEnd = 407923, XrefRangeStart = 407918, XrefRangeEnd = 407922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00009294 File Offset: 0x00007494
		public AxisStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0006B48C File Offset: 0x0006968C
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x0000929D File Offset: 0x0000749D
		public unsafe ArrayList stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0006B4BC File Offset: 0x000696BC
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x000092BC File Offset: 0x000074BC
		public unsafe ForwardAxis subtree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_subtree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForwardAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_subtree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0006B4EC File Offset: 0x000696EC
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x000092DB File Offset: 0x000074DB
		public unsafe ActiveAxis parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr_subtree;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Void_Int32_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Void_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0;
	}
}
