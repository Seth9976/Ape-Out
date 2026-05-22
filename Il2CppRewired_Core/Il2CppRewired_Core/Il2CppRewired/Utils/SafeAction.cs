using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E4 RID: 484
	public sealed class SafeAction : SafeDelegate<Action>
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x000F54F4 File Offset: 0x000F36F4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeAction()
		{
			Il2CppClassPointerStore<SafeAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAction>.NativeClassPtr);
			SafeAction.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, "gBHYUjlrgPpCcxohnMBNikgNzss");
			SafeAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675827);
			SafeAction.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675828);
			SafeAction.NativeMethodInfoPtr__ctor_Private_Void_SafeAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675829);
			SafeAction.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675830);
			SafeAction.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675831);
			SafeAction.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675832);
			SafeAction.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675833);
			SafeAction.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_SafeAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675834);
			SafeAction.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_SafeAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675835);
			SafeAction.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_SafeAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675836);
			SafeAction.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAction>.NativeClassPtr, 100675837);
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000F5614 File Offset: 0x000F3814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337108, XrefRangeEnd = 337111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000F5650 File Offset: 0x000F3850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337111, XrefRangeEnd = 337113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(Action<Exception> exceptionHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000F569C File Offset: 0x000F389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337113, XrefRangeEnd = 337119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAction(SafeAction source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr__ctor_Private_Void_SafeAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000F56E8 File Offset: 0x000F38E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 337137, RefRangeEnd = 337143, XrefRangeStart = 337119, XrefRangeEnd = 337137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000F571C File Offset: 0x000F391C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337143, XrefRangeEnd = 337152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x000F575C File Offset: 0x000F395C
		public unsafe static Action<Object, Action> invokeDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337152, XrefRangeEnd = 337161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000F5790 File Offset: 0x000F3990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337161, XrefRangeEnd = 337162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IeDiRNoROqgJggMJIWRwJAkyOMlt(Object A_0, Action A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000F57D8 File Offset: 0x000F39D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337162, XrefRangeEnd = 337171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction operator +(SafeAction eventList, Action listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_SafeAction_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction>(intPtr3) : null;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000F5830 File Offset: 0x000F3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337171, XrefRangeEnd = 337174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeAction operator -(SafeAction eventList, Action listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_SafeAction_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction>(intPtr3) : null;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x000F5888 File Offset: 0x000F3A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337174, XrefRangeEnd = 337177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Action(SafeAction obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_SafeAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x000F58CC File Offset: 0x000F3ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337177, XrefRangeEnd = 337186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SafeAction(Action obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAction.NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeAction>(intPtr3) : null;
			}
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00011BB9 File Offset: 0x0000FDB9
		public SafeAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000F5910 File Offset: 0x000F3B10
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x00011BC2 File Offset: 0x0000FDC2
		public unsafe static Action<Object, Action> gBHYUjlrgPpCcxohnMBNikgNzss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeAction.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Action>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeAction.NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeFieldInfoPtr_gBHYUjlrgPpCcxohnMBNikgNzss;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_Exception_0;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SafeAction_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_get_invokeDelegate_Private_Static_get_Action_2_Object_Action_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_IeDiRNoROqgJggMJIWRwJAkyOMlt_Private_Static_Void_Object_Action_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SafeAction_SafeAction_Action_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SafeAction_SafeAction_Action_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Action_SafeAction_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SafeAction_Action_0;
	}
}
