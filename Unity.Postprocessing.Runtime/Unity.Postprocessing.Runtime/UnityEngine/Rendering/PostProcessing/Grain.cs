using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000024 RID: 36
	[Serializable]
	public sealed class Grain : PostProcessEffectSettings
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00009A10 File Offset: 0x00007C10
		// Note: this type is marked as 'beforefieldinit'.
		static Grain()
		{
			Il2CppClassPointerStore<Grain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Grain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grain>.NativeClassPtr);
			Grain.NativeFieldInfoPtr_colored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grain>.NativeClassPtr, "colored");
			Grain.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grain>.NativeClassPtr, "intensity");
			Grain.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grain>.NativeClassPtr, "size");
			Grain.NativeFieldInfoPtr_lumContrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grain>.NativeClassPtr, "lumContrib");
			Grain.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grain>.NativeClassPtr, 100663373);
			Grain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grain>.NativeClassPtr, 100663374);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00009AB8 File Offset: 0x00007CB8
		[CallerCount(0)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grain.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009B08 File Offset: 0x00007D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443363, XrefRangeEnd = 443383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002F76 File Offset: 0x00001176
		public Grain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00009B44 File Offset: 0x00007D44
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002F7F File Offset: 0x0000117F
		public unsafe BoolParameter colored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_colored);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_colored), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00009B74 File Offset: 0x00007D74
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002F9E File Offset: 0x0000119E
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00009BA4 File Offset: 0x00007DA4
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002FBD File Offset: 0x000011BD
		public unsafe FloatParameter size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_size);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_size), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00009BD4 File Offset: 0x00007DD4
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002FDC File Offset: 0x000011DC
		public unsafe FloatParameter lumContrib
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_lumContrib);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grain.NativeFieldInfoPtr_lumContrib), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_colored;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_lumContrib;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
