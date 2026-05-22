using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200014E RID: 334
	public sealed class KeyboardMap : ControllerMap
	{
		// Token: 0x06002552 RID: 9554 RVA: 0x000BED00 File Offset: 0x000BCF00
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardMap()
		{
			Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "KeyboardMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr);
			KeyboardMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr, 100671431);
			KeyboardMap.NativeMethodInfoPtr__ctor_Public_Void_KeyboardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr, 100671432);
			KeyboardMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr, 100671433);
			KeyboardMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_KeyboardMap_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr, 100671434);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000BED80 File Offset: 0x000BCF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293959, XrefRangeEnd = 293963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000BEDBC File Offset: 0x000BCFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293963, XrefRangeEnd = 293967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardMap(KeyboardMap keyboardMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyboardMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMap.NativeMethodInfoPtr__ctor_Public_Void_KeyboardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000BEE08 File Offset: 0x000BD008
		[CallerCount(0)]
		public unsafe void SUdOyevPRMOQVCnWgtObyPwvIsY(Guid A_1, int A_2, int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000BEE64 File Offset: 0x000BD064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293967, XrefRangeEnd = 293974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyboardMap XURQGtObEHUkeLhWMKKYUVgbnZt(Guid A_0, int A_1, int A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_KeyboardMap_Guid_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyboardMap>(intPtr3) : null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0000E979 File Offset: 0x0000CB79
		public KeyboardMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyboardMap_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_KeyboardMap_Guid_Int32_Int32_0;
	}
}
