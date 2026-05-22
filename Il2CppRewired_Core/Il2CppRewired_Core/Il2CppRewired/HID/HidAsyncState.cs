using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000114 RID: 276
	public class HidAsyncState : Object
	{
		// Token: 0x06001A6B RID: 6763 RVA: 0x00093988 File Offset: 0x00091B88
		// Note: this type is marked as 'beforefieldinit'.
		static HidAsyncState()
		{
			Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HidAsyncState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr);
			HidAsyncState.NativeFieldInfoPtr_wrWJdEQKfgTZaDNLLJufnqFhXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr, "wrWJdEQKfgTZaDNLLJufnqFhXsd");
			HidAsyncState.NativeFieldInfoPtr_WkkURSxnvnxVqdIiGzUvHfESyI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr, "WkkURSxnvnxVqdIiGzUvHfESyI");
			HidAsyncState.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr, 100669499);
			HidAsyncState.NativeMethodInfoPtr_get_CallerDelegate_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr, 100669500);
			HidAsyncState.NativeMethodInfoPtr_get_CallbackDelegate_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr, 100669501);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00093A1C File Offset: 0x00091C1C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HidAsyncState(Object callerDelegate, Object callbackDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HidAsyncState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callerDelegate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidAsyncState.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00093A7C File Offset: 0x00091C7C
		public unsafe Object CallerDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidAsyncState.NativeMethodInfoPtr_get_CallerDelegate_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00093ABC File Offset: 0x00091CBC
		public unsafe Object CallbackDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidAsyncState.NativeMethodInfoPtr_get_CallbackDelegate_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0000AD9D File Offset: 0x00008F9D
		public HidAsyncState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00093AFC File Offset: 0x00091CFC
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000ADA6 File Offset: 0x00008FA6
		public unsafe Object wrWJdEQKfgTZaDNLLJufnqFhXsd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidAsyncState.NativeFieldInfoPtr_wrWJdEQKfgTZaDNLLJufnqFhXsd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidAsyncState.NativeFieldInfoPtr_wrWJdEQKfgTZaDNLLJufnqFhXsd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x00093B2C File Offset: 0x00091D2C
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000ADC5 File Offset: 0x00008FC5
		public unsafe Object WkkURSxnvnxVqdIiGzUvHfESyI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidAsyncState.NativeFieldInfoPtr_WkkURSxnvnxVqdIiGzUvHfESyI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidAsyncState.NativeFieldInfoPtr_WkkURSxnvnxVqdIiGzUvHfESyI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_wrWJdEQKfgTZaDNLLJufnqFhXsd;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_WkkURSxnvnxVqdIiGzUvHfESyI;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_get_CallerDelegate_Public_get_Object_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackDelegate_Public_get_Object_0;
	}
}
