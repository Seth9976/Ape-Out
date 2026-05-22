using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001BA RID: 442
	public class StreetPicker : MonoBehaviour
	{
		// Token: 0x0600310A RID: 12554 RVA: 0x000BB54C File Offset: 0x000B974C
		// Note: this type is marked as 'beforefieldinit'.
		static StreetPicker()
		{
			Il2CppClassPointerStore<StreetPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StreetPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetPicker>.NativeClassPtr);
			StreetPicker.NativeFieldInfoPtr_skyBridgeAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetPicker>.NativeClassPtr, "skyBridgeAudio");
			StreetPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetPicker>.NativeClassPtr, 100667141);
			StreetPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetPicker>.NativeClassPtr, 100667142);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000BB5B8 File Offset: 0x000B97B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84881, XrefRangeEnd = 84915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000BB5EC File Offset: 0x000B97EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x00021A62 File Offset: 0x0001FC62
		public StreetPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x000BB628 File Offset: 0x000B9828
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x00021A6B File Offset: 0x0001FC6B
		public unsafe bool skyBridgeAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetPicker.NativeFieldInfoPtr_skyBridgeAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetPicker.NativeFieldInfoPtr_skyBridgeAudio)) = value;
			}
		}

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeFieldInfoPtr_skyBridgeAudio;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
