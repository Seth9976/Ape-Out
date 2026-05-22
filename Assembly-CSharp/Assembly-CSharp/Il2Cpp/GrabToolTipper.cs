using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E9 RID: 233
	public class GrabToolTipper : MonoBehaviour
	{
		// Token: 0x06001BCF RID: 7119 RVA: 0x00082A08 File Offset: 0x00080C08
		// Note: this type is marked as 'beforefieldinit'.
		static GrabToolTipper()
		{
			Il2CppClassPointerStore<GrabToolTipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GrabToolTipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabToolTipper>.NativeClassPtr);
			GrabToolTipper.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabToolTipper>.NativeClassPtr, 100665568);
			GrabToolTipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabToolTipper>.NativeClassPtr, 100665569);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00082A60 File Offset: 0x00080C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62549, XrefRangeEnd = 62561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabToolTipper.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00082A94 File Offset: 0x00080C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrabToolTipper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabToolTipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabToolTipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000139F6 File Offset: 0x00011BF6
		public GrabToolTipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
