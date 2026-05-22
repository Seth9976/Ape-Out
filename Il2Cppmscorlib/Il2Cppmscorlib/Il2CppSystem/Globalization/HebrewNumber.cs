using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023F RID: 575
	public class HebrewNumber : Object
	{
		// Token: 0x060026CE RID: 9934 RVA: 0x000D08A0 File Offset: 0x000CEAA0
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumber()
		{
			Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr);
			HebrewNumber.NativeFieldInfoPtr_HebrewValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValues");
			HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "maxHebrewNumberCh");
			HebrewNumber.NativeFieldInfoPtr_NumberPasingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "NumberPasingState");
			HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669688);
			HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669689);
			HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669690);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000D0948 File Offset: 0x000CEB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196149, RefRangeEnd = 196150, XrefRangeStart = 196123, XrefRangeEnd = 196149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int Number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000D0980 File Offset: 0x000CEB80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196159, RefRangeEnd = 196161, XrefRangeStart = 196150, XrefRangeEnd = 196159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000D09CC File Offset: 0x000CEBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196161, XrefRangeEnd = 196167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0000D2AA File Offset: 0x0000B4AA
		public HebrewNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000D0A0C File Offset: 0x000CEC0C
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0000D2B3 File Offset: 0x0000B4B3
		public unsafe static Il2CppReferenceArray<HebrewNumber.HebrewValue> HebrewValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_HebrewValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HebrewNumber.HebrewValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_HebrewValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000D0A34 File Offset: 0x000CEC34
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0000D2C5 File Offset: 0x0000B4C5
		public unsafe static char maxHebrewNumberCh
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh, (void*)(&value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000D0A50 File Offset: 0x000CEC50
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0000D2D3 File Offset: 0x0000B4D3
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<HebrewNumber.HS>> NumberPasingState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_NumberPasingState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<HebrewNumber.HS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_NumberPasingState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeFieldInfoPtr_HebrewValues;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeFieldInfoPtr_maxHebrewNumberCh;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeFieldInfoPtr_NumberPasingState;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x020005E2 RID: 1506
		[OriginalName("mscorlib.dll", "", "HebrewToken")]
		public enum HebrewToken
		{
			// Token: 0x040043CB RID: 17355
			Invalid = -1,
			// Token: 0x040043CC RID: 17356
			Digit400,
			// Token: 0x040043CD RID: 17357
			Digit200_300,
			// Token: 0x040043CE RID: 17358
			Digit100,
			// Token: 0x040043CF RID: 17359
			Digit10,
			// Token: 0x040043D0 RID: 17360
			Digit1,
			// Token: 0x040043D1 RID: 17361
			Digit6_7,
			// Token: 0x040043D2 RID: 17362
			Digit7,
			// Token: 0x040043D3 RID: 17363
			Digit9,
			// Token: 0x040043D4 RID: 17364
			SingleQuote,
			// Token: 0x040043D5 RID: 17365
			DoubleQuote
		}

		// Token: 0x020005E3 RID: 1507
		public class HebrewValue : Object
		{
			// Token: 0x060053CA RID: 21450 RVA: 0x001796EC File Offset: 0x001778EC
			// Note: this type is marked as 'beforefieldinit'.
			static HebrewValue()
			{
				Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr);
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "token");
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "value");
				HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, 100669692);
			}

			// Token: 0x060053CB RID: 21451 RVA: 0x00179754 File Offset: 0x00177954
			[CallerCount(0)]
			public unsafe HebrewValue(HebrewNumber.HebrewToken token, int value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053CC RID: 21452 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
			public HebrewValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001579 RID: 5497
			// (get) Token: 0x060053CD RID: 21453 RVA: 0x001797AC File Offset: 0x001779AC
			// (set) Token: 0x060053CE RID: 21454 RVA: 0x0001F8A9 File Offset: 0x0001DAA9
			public unsafe HebrewNumber.HebrewToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_token)) = value;
				}
			}

			// Token: 0x1700157A RID: 5498
			// (get) Token: 0x060053CF RID: 21455 RVA: 0x001797D4 File Offset: 0x001779D4
			// (set) Token: 0x060053D0 RID: 21456 RVA: 0x0001F8C4 File Offset: 0x0001DAC4
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040043D6 RID: 17366
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x040043D7 RID: 17367
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040043D8 RID: 17368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0;
		}

		// Token: 0x020005E4 RID: 1508
		[OriginalName("mscorlib.dll", "", "HS")]
		public enum HS
		{
			// Token: 0x040043DA RID: 17370
			_err = -1,
			// Token: 0x040043DB RID: 17371
			Start,
			// Token: 0x040043DC RID: 17372
			S400,
			// Token: 0x040043DD RID: 17373
			S400_400,
			// Token: 0x040043DE RID: 17374
			S400_X00,
			// Token: 0x040043DF RID: 17375
			S400_X0,
			// Token: 0x040043E0 RID: 17376
			X00_DQ,
			// Token: 0x040043E1 RID: 17377
			S400_X00_X0,
			// Token: 0x040043E2 RID: 17378
			X0_DQ,
			// Token: 0x040043E3 RID: 17379
			X,
			// Token: 0x040043E4 RID: 17380
			X0,
			// Token: 0x040043E5 RID: 17381
			X00,
			// Token: 0x040043E6 RID: 17382
			S400_DQ,
			// Token: 0x040043E7 RID: 17383
			S400_400_DQ,
			// Token: 0x040043E8 RID: 17384
			S400_400_100,
			// Token: 0x040043E9 RID: 17385
			S9,
			// Token: 0x040043EA RID: 17386
			X00_S9,
			// Token: 0x040043EB RID: 17387
			S9_DQ,
			// Token: 0x040043EC RID: 17388
			END = 100
		}
	}
}
