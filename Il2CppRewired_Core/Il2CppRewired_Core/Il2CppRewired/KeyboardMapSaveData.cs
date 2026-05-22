using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000148 RID: 328
	public sealed class KeyboardMapSaveData : ControllerMapSaveData
	{
		// Token: 0x060023FB RID: 9211 RVA: 0x000B653C File Offset: 0x000B473C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardMapSaveData()
		{
			Il2CppClassPointerStore<KeyboardMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "KeyboardMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardMapSaveData>.NativeClassPtr);
			KeyboardMapSaveData.NativeMethodInfoPtr_get_keyboardMap_Public_get_KeyboardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMapSaveData>.NativeClassPtr, 100671035);
			KeyboardMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Keyboard_KeyboardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMapSaveData>.NativeClassPtr, 100671036);
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000B6594 File Offset: 0x000B4794
		public unsafe KeyboardMap keyboardMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290053, XrefRangeEnd = 290062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMapSaveData.NativeMethodInfoPtr_get_keyboardMap_Public_get_KeyboardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyboardMap>(intPtr3) : null;
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000B65D4 File Offset: 0x000B47D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290062, XrefRangeEnd = 290063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardMapSaveData(Keyboard keyboard, KeyboardMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyboard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Keyboard_KeyboardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0000E74E File Offset: 0x0000C94E
		public KeyboardMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardMap_Public_get_KeyboardMap_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Keyboard_KeyboardMap_0;
	}
}
