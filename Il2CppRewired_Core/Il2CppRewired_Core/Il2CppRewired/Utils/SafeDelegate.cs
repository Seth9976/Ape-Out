using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001E2 RID: 482
	public class SafeDelegate : Object
	{
		// Token: 0x06003141 RID: 12609 RVA: 0x000F4884 File Offset: 0x000F2A84
		// Note: this type is marked as 'beforefieldinit'.
		static SafeDelegate()
		{
			Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "SafeDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr);
			SafeDelegate.NativeFieldInfoPtr_pKMyjhBhnIIYlBSgTcqPEGTCngAJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, "pKMyjhBhnIIYlBSgTcqPEGTCngAJ");
			SafeDelegate.NativeMethodInfoPtr_get_Count_Internal_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675797);
			SafeDelegate.NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675798);
			SafeDelegate.NativeMethodInfoPtr_get_ExceptionHandler_Internal_Abstract_Virtual_New_get_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675799);
			SafeDelegate.NativeMethodInfoPtr_set_ExceptionHandler_Internal_Abstract_Virtual_New_set_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675800);
			SafeDelegate.NativeMethodInfoPtr_Clear_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675801);
			SafeDelegate.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675802);
			SafeDelegate.NativeMethodInfoPtr_get_S_ExceptionHandler_Internal_Static_get_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675803);
			SafeDelegate.NativeMethodInfoPtr_set_S_ExceptionHandler_Internal_Static_set_Void_Action_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675804);
			SafeDelegate.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr, 100675805);
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x000F497C File Offset: 0x000F2B7C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_get_Count_Internal_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000F49C4 File Offset: 0x000F2BC4
		[CallerCount(0)]
		public unsafe virtual void RemoveDelegateOrAllDelegatesFromAnObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x000F4A14 File Offset: 0x000F2C14
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x000F4A60 File Offset: 0x000F2C60
		public unsafe virtual Action<Exception> ExceptionHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_get_ExceptionHandler_Internal_Abstract_Virtual_New_get_Action_1_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_set_ExceptionHandler_Internal_Abstract_Virtual_New_set_Void_Action_1_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000F4AB0 File Offset: 0x000F2CB0
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_Clear_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000F4AEC File Offset: 0x000F2CEC
		[CallerCount(0)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeDelegate.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x000F4B38 File Offset: 0x000F2D38
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x000F4B6C File Offset: 0x000F2D6C
		public unsafe static Action<Exception> S_ExceptionHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336917, XrefRangeEnd = 336919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate.NativeMethodInfoPtr_get_S_ExceptionHandler_Internal_Static_get_Action_1_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336919, XrefRangeEnd = 336921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate.NativeMethodInfoPtr_set_S_ExceptionHandler_Internal_Static_set_Void_Action_1_Exception_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000F4BA4 File Offset: 0x000F2DA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeDelegate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeDelegate.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00011B38 File Offset: 0x0000FD38
		public SafeDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x000F4BE0 File Offset: 0x000F2DE0
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00011B41 File Offset: 0x0000FD41
		public unsafe static Action<Exception> pKMyjhBhnIIYlBSgTcqPEGTCngAJ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeDelegate.NativeFieldInfoPtr_pKMyjhBhnIIYlBSgTcqPEGTCngAJ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeDelegate.NativeFieldInfoPtr_pKMyjhBhnIIYlBSgTcqPEGTCngAJ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeFieldInfoPtr_pKMyjhBhnIIYlBSgTcqPEGTCngAJ;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDelegateOrAllDelegatesFromAnObject_Internal_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionHandler_Internal_Abstract_Virtual_New_get_Action_1_Exception_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_set_ExceptionHandler_Internal_Abstract_Virtual_New_set_Void_Action_1_Exception_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_get_S_ExceptionHandler_Internal_Static_get_Action_1_Exception_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_set_S_ExceptionHandler_Internal_Static_set_Void_Action_1_Exception_0;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
