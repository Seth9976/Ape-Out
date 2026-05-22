using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000063 RID: 99
	public static class ScalableBufferManager : Object
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00026BE4 File Offset: 0x00024DE4
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableBufferManager()
		{
			Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScalableBufferManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr);
			ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100663819);
			ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100663820);
			ScalableBufferManager.ResizeBuffersDelegateField = IL2CPP.ResolveICall<ScalableBufferManager.ResizeBuffersDelegate>("UnityEngine.ScalableBufferManager::ResizeBuffers");
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00026C4C File Offset: 0x00024E4C
		public unsafe static float widthScaleFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488103, XrefRangeEnd = 488107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00026C7C File Offset: 0x00024E7C
		public unsafe static float heightScaleFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488107, XrefRangeEnd = 488111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00005687 File Offset: 0x00003887
		public ScalableBufferManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00005690 File Offset: 0x00003890
		public static void ResizeBuffers(float widthScale, float heightScale)
		{
			ScalableBufferManager.ResizeBuffersDelegateField(widthScale, heightScale);
		}

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly ScalableBufferManager.ResizeBuffersDelegate ResizeBuffersDelegateField;

		// Token: 0x02000490 RID: 1168
		// (Invoke) Token: 0x06002756 RID: 10070
		private delegate void ResizeBuffersDelegate(float widthScale, float heightScale);
	}
}
