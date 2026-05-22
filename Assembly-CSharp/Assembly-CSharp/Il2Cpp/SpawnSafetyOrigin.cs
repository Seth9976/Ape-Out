using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A3 RID: 419
	public class SpawnSafetyOrigin : MonoBehaviour
	{
		// Token: 0x06003049 RID: 12361 RVA: 0x000B9440 File Offset: 0x000B7640
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnSafetyOrigin()
		{
			Il2CppClassPointerStore<SpawnSafetyOrigin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpawnSafetyOrigin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnSafetyOrigin>.NativeClassPtr);
			SpawnSafetyOrigin.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSafetyOrigin>.NativeClassPtr, 100667078);
			SpawnSafetyOrigin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSafetyOrigin>.NativeClassPtr, 100667079);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000B9498 File Offset: 0x000B7698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84224, XrefRangeEnd = 84230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnSafetyOrigin.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000B94CC File Offset: 0x000B76CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnSafetyOrigin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnSafetyOrigin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnSafetyOrigin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000213B0 File Offset: 0x0001F5B0
		public SpawnSafetyOrigin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
