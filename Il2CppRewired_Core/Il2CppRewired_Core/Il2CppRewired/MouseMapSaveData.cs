using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000149 RID: 329
	public sealed class MouseMapSaveData : ControllerMapSaveData
	{
		// Token: 0x060023FF RID: 9215 RVA: 0x000B6634 File Offset: 0x000B4834
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMapSaveData()
		{
			Il2CppClassPointerStore<MouseMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "MouseMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMapSaveData>.NativeClassPtr);
			MouseMapSaveData.NativeMethodInfoPtr_get_keyboardMap_Public_get_MouseMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMapSaveData>.NativeClassPtr, 100671037);
			MouseMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Mouse_MouseMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMapSaveData>.NativeClassPtr, 100671038);
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000B668C File Offset: 0x000B488C
		public unsafe MouseMap keyboardMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290063, XrefRangeEnd = 290072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMapSaveData.NativeMethodInfoPtr_get_keyboardMap_Public_get_MouseMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMap>(intPtr3) : null;
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000B66CC File Offset: 0x000B48CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMapSaveData(Mouse mouse, MouseMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mouse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Mouse_MouseMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0000E757 File Offset: 0x0000C957
		public MouseMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardMap_Public_get_MouseMap_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Mouse_MouseMap_0;
	}
}
