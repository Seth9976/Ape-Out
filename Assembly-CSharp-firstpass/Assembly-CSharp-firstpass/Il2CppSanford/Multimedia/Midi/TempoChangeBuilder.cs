using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B5 RID: 437
	public class TempoChangeBuilder : Object
	{
		// Token: 0x060014DF RID: 5343 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
		// Note: this type is marked as 'beforefieldinit'.
		static TempoChangeBuilder()
		{
			Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "TempoChangeBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr);
			TempoChangeBuilder.NativeFieldInfoPtr_Shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, "Shift");
			TempoChangeBuilder.NativeFieldInfoPtr_tempo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, "tempo");
			TempoChangeBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, "result");
			TempoChangeBuilder.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, "changed");
			TempoChangeBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666261);
			TempoChangeBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666262);
			TempoChangeBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666263);
			TempoChangeBuilder.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666264);
			TempoChangeBuilder.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666265);
			TempoChangeBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666266);
			TempoChangeBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr, 100666267);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000600F4 File Offset: 0x0005E2F4
		[CallerCount(0)]
		public unsafe TempoChangeBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00060130 File Offset: 0x0005E330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16337, XrefRangeEnd = 16338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TempoChangeBuilder(MetaMessage e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempoChangeBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006017C File Offset: 0x0005E37C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16346, RefRangeEnd = 16349, XrefRangeStart = 16338, XrefRangeEnd = 16346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MetaMessage e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000601C0 File Offset: 0x0005E3C0
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000601FC File Offset: 0x0005E3FC
		public unsafe int Tempo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0006023C File Offset: 0x0005E43C
		public unsafe MetaMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0006027C File Offset: 0x0005E47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16349, XrefRangeEnd = 16362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempoChangeBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000087FA File Offset: 0x000069FA
		public TempoChangeBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x000602B0 File Offset: 0x0005E4B0
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00008803 File Offset: 0x00006A03
		public unsafe static int Shift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TempoChangeBuilder.NativeFieldInfoPtr_Shift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TempoChangeBuilder.NativeFieldInfoPtr_Shift, (void*)(&value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x000602CC File Offset: 0x0005E4CC
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x00008811 File Offset: 0x00006A11
		public unsafe int tempo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_tempo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_tempo)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000602F4 File Offset: 0x0005E4F4
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0000882C File Offset: 0x00006A2C
		public unsafe MetaMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00060324 File Offset: 0x0005E524
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0000884B File Offset: 0x00006A4B
		public unsafe bool changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempoChangeBuilder.NativeFieldInfoPtr_changed)) = value;
			}
		}

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeFieldInfoPtr_Shift;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_tempo;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_get_Tempo_Public_get_Int32_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_set_Tempo_Public_set_Void_Int32_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
