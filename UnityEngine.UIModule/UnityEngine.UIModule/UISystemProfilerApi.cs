using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public static class UISystemProfilerApi : Object
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000049DC File Offset: 0x00002BDC
		// Note: this type is marked as 'beforefieldinit'.
		static UISystemProfilerApi()
		{
			Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "UISystemProfilerApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr);
			UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663392);
			UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663393);
			UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663394);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004A48 File Offset: 0x00002C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534092, XrefRangeEnd = 534096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004A7C File Offset: 0x00002C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534096, XrefRangeEnd = 534100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004AB0 File Offset: 0x00002CB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 534104, RefRangeEnd = 534110, XrefRangeStart = 534100, XrefRangeEnd = 534104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMarker(string name, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000022DB File Offset: 0x000004DB
		public UISystemProfilerApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0;

		// Token: 0x02000024 RID: 36
		[OriginalName("UnityEngine.UIModule.dll", "", "SampleType")]
		public enum SampleType
		{
			// Token: 0x0400008B RID: 139
			Layout,
			// Token: 0x0400008C RID: 140
			Render
		}
	}
}
