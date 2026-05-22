using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000150 RID: 336
	public sealed class JoystickMap : ControllerMapWithAxes
	{
		// Token: 0x0600255E RID: 9566 RVA: 0x000BF080 File Offset: 0x000BD280
		// Note: this type is marked as 'beforefieldinit'.
		static JoystickMap()
		{
			Il2CppClassPointerStore<JoystickMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "JoystickMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr);
			JoystickMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr, 100671439);
			JoystickMap.NativeMethodInfoPtr__ctor_Public_Void_JoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr, 100671440);
			JoystickMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr, 100671441);
			JoystickMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_JoystickMap_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr, 100671442);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000BF100 File Offset: 0x000BD300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000BF13C File Offset: 0x000BD33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickMap(JoystickMap joystickMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystickMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMap.NativeMethodInfoPtr__ctor_Public_Void_JoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000BF188 File Offset: 0x000BD388
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000BF1E4 File Offset: 0x000BD3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293980, XrefRangeEnd = 293984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JoystickMap XURQGtObEHUkeLhWMKKYUVgbnZt(Guid A_0, int A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_JoystickMap_Guid_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JoystickMap>(intPtr3) : null;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0000E98B File Offset: 0x0000CB8B
		public JoystickMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JoystickMap_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_JoystickMap_Guid_Int32_Int32_0;
	}
}
