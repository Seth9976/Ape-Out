using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B6 RID: 438
	public class TimeSignatureBuilder : Object
	{
		// Token: 0x060014F0 RID: 5360 RVA: 0x0006034C File Offset: 0x0005E54C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSignatureBuilder()
		{
			Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "TimeSignatureBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr);
			TimeSignatureBuilder.NativeFieldInfoPtr_DefaultNumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "DefaultNumerator");
			TimeSignatureBuilder.NativeFieldInfoPtr_DefaultDenominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "DefaultDenominator");
			TimeSignatureBuilder.NativeFieldInfoPtr_DefaultClocksPerMetronomeClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "DefaultClocksPerMetronomeClick");
			TimeSignatureBuilder.NativeFieldInfoPtr_DefaultThirtySecondNotesPerQuarterNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "DefaultThirtySecondNotesPerQuarterNote");
			TimeSignatureBuilder.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "data");
			TimeSignatureBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "result");
			TimeSignatureBuilder.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, "changed");
			TimeSignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666268);
			TimeSignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666269);
			TimeSignatureBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666270);
			TimeSignatureBuilder.NativeMethodInfoPtr_get_Numerator_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666271);
			TimeSignatureBuilder.NativeMethodInfoPtr_set_Numerator_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666272);
			TimeSignatureBuilder.NativeMethodInfoPtr_get_Denominator_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666273);
			TimeSignatureBuilder.NativeMethodInfoPtr_set_Denominator_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666274);
			TimeSignatureBuilder.NativeMethodInfoPtr_get_ClocksPerMetronomeClick_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666275);
			TimeSignatureBuilder.NativeMethodInfoPtr_set_ClocksPerMetronomeClick_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666276);
			TimeSignatureBuilder.NativeMethodInfoPtr_get_ThirtySecondNotesPerQuarterNote_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666277);
			TimeSignatureBuilder.NativeMethodInfoPtr_set_ThirtySecondNotesPerQuarterNote_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666278);
			TimeSignatureBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666279);
			TimeSignatureBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr, 100666280);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0006050C File Offset: 0x0005E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16362, XrefRangeEnd = 16373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSignatureBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00060548 File Offset: 0x0005E748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16373, XrefRangeEnd = 16377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSignatureBuilder(MetaMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSignatureBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00060594 File Offset: 0x0005E794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16377, XrefRangeEnd = 16378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x000605D8 File Offset: 0x0005E7D8
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00060614 File Offset: 0x0005E814
		public unsafe byte Numerator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_get_Numerator_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_set_Numerator_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00060654 File Offset: 0x0005E854
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00060690 File Offset: 0x0005E890
		public unsafe byte Denominator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16378, XrefRangeEnd = 16394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_get_Denominator_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16394, XrefRangeEnd = 16402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_set_Denominator_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000606D0 File Offset: 0x0005E8D0
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x0006070C File Offset: 0x0005E90C
		public unsafe byte ClocksPerMetronomeClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_get_ClocksPerMetronomeClick_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_set_ClocksPerMetronomeClick_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0006074C File Offset: 0x0005E94C
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x00060788 File Offset: 0x0005E988
		public unsafe byte ThirtySecondNotesPerQuarterNote
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_get_ThirtySecondNotesPerQuarterNote_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_set_ThirtySecondNotesPerQuarterNote_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000607C8 File Offset: 0x0005E9C8
		public unsafe MetaMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00060808 File Offset: 0x0005EA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16402, XrefRangeEnd = 16406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSignatureBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00008866 File Offset: 0x00006A66
		public TimeSignatureBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0006083C File Offset: 0x0005EA3C
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x0000886F File Offset: 0x00006A6F
		public unsafe static byte DefaultNumerator
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultNumerator, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultNumerator, (void*)(&value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00060858 File Offset: 0x0005EA58
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0000887D File Offset: 0x00006A7D
		public unsafe static byte DefaultDenominator
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultDenominator, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultDenominator, (void*)(&value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00060874 File Offset: 0x0005EA74
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x0000888B File Offset: 0x00006A8B
		public unsafe static byte DefaultClocksPerMetronomeClick
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultClocksPerMetronomeClick, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultClocksPerMetronomeClick, (void*)(&value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00060890 File Offset: 0x0005EA90
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00008899 File Offset: 0x00006A99
		public unsafe static byte DefaultThirtySecondNotesPerQuarterNote
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultThirtySecondNotesPerQuarterNote, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSignatureBuilder.NativeFieldInfoPtr_DefaultThirtySecondNotesPerQuarterNote, (void*)(&value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000608AC File Offset: 0x0005EAAC
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x000088A7 File Offset: 0x00006AA7
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000608DC File Offset: 0x0005EADC
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x000088C6 File Offset: 0x00006AC6
		public unsafe MetaMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0006090C File Offset: 0x0005EB0C
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x000088E5 File Offset: 0x00006AE5
		public unsafe bool changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSignatureBuilder.NativeFieldInfoPtr_changed)) = value;
			}
		}

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_DefaultNumerator;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDenominator;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_DefaultClocksPerMetronomeClick;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_DefaultThirtySecondNotesPerQuarterNote;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_get_Numerator_Public_get_Byte_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_set_Numerator_Public_set_Void_Byte_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_get_Denominator_Public_get_Byte_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_set_Denominator_Public_set_Void_Byte_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_get_ClocksPerMetronomeClick_Public_get_Byte_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_set_ClocksPerMetronomeClick_Public_set_Void_Byte_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_get_ThirtySecondNotesPerQuarterNote_Public_get_Byte_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_set_ThirtySecondNotesPerQuarterNote_Public_set_Void_Byte_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
