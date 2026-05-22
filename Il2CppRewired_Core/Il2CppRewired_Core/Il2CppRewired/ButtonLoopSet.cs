using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000029 RID: 41
	public class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData>
	{
		// Token: 0x06000334 RID: 820 RVA: 0x0003A0CC File Offset: 0x000382CC
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonLoopSet()
		{
			Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ButtonLoopSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr);
			ButtonLoopSet.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, "buttonCount");
			ButtonLoopSet.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, 100663815);
			ButtonLoopSet.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, 100663816);
			ButtonLoopSet.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, 100663817);
			ButtonLoopSet.NativeMethodInfoPtr_Import_Public_Void_ButtonLoopSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, 100663818);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0003A160 File Offset: 0x00038360
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 244543, RefRangeEnd = 244548, XrefRangeStart = 244534, XrefRangeEnd = 244543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoops;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0003A1B8 File Offset: 0x000383B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244560, RefRangeEnd = 244568, XrefRangeStart = 244548, XrefRangeEnd = 244560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int index, bool value, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0003A214 File Offset: 0x00038414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244581, RefRangeEnd = 244583, XrefRangeStart = 244568, XrefRangeEnd = 244581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0003A248 File Offset: 0x00038448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244583, XrefRangeEnd = 244590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import(ButtonLoopSet set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.NativeMethodInfoPtr_Import_Public_Void_ButtonLoopSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000030EE File Offset: 0x000012EE
		public ButtonLoopSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0003A28C File Offset: 0x0003848C
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000030F7 File Offset: 0x000012F7
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_Double_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_ButtonLoopSet_0;

		// Token: 0x02000235 RID: 565
		public class ButtonData : Object
		{
			// Token: 0x0600381F RID: 14367 RVA: 0x00113CF4 File Offset: 0x00111EF4
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonData()
			{
				Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonLoopSet>.NativeClassPtr, "ButtonData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr);
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_updateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "updateLoop");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "values");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_wasTrueThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "wasTrueThisFrame");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_NZXsgdVvVxkkVIMMsgAUhTNzlXJr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "NZXsgdVvVxkkVIMMsgAUhTNzlXJr");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_YWoYmKEfatLPRZrbjKiKHLvQPXl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "YWoYmKEfatLPRZrbjKiKHLvQPXl");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_ltEmHoALiripIkSEjwFjPQQZVaVQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "ltEmHoALiripIkSEjwFjPQQZVaVQ");
				ButtonLoopSet.ButtonData.NativeFieldInfoPtr_AczkMBDvBRgsizmVQODFflyexlg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, "AczkMBDvBRgsizmVQODFflyexlg");
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_get_effectiveValue_Public_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663819);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663820);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663821);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_ClearWasTrueThisFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663822);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663823);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_Import_Public_Void_ButtonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663824);
				ButtonLoopSet.ButtonData.NativeMethodInfoPtr_aBtBcSNInIxMETcIBoKxcEWHXSw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr, 100663825);
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x06003820 RID: 14368 RVA: 0x00113E38 File Offset: 0x00112038
			public unsafe Il2CppStructArray<bool> effectiveValue
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244477, XrefRangeEnd = 244478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_get_effectiveValue_Public_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06003821 RID: 14369 RVA: 0x00113E78 File Offset: 0x00112078
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 244493, RefRangeEnd = 244494, XrefRangeStart = 244478, XrefRangeEnd = 244493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonData(int count, UpdateLoopType updateLoop)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonLoopSet.ButtonData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003822 RID: 14370 RVA: 0x00113ED0 File Offset: 0x001120D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244494, XrefRangeEnd = 244495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(int index, bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003823 RID: 14371 RVA: 0x00113F1C File Offset: 0x0011211C
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 244496, RefRangeEnd = 244505, XrefRangeStart = 244495, XrefRangeEnd = 244496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearWasTrueThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_ClearWasTrueThisFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003824 RID: 14372 RVA: 0x00113F50 File Offset: 0x00112150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244505, XrefRangeEnd = 244514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003825 RID: 14373 RVA: 0x00113F84 File Offset: 0x00112184
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 244514, RefRangeEnd = 244516, XrefRangeStart = 244514, XrefRangeEnd = 244514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Import(ButtonLoopSet.ButtonData source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_Import_Public_Void_ButtonData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003826 RID: 14374 RVA: 0x00113FC8 File Offset: 0x001121C8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 244524, RefRangeEnd = 244534, XrefRangeStart = 244516, XrefRangeEnd = 244524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void aBtBcSNInIxMETcIBoKxcEWHXSw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonLoopSet.ButtonData.NativeMethodInfoPtr_aBtBcSNInIxMETcIBoKxcEWHXSw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003827 RID: 14375 RVA: 0x0001367D File Offset: 0x0001187D
			public ButtonData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x06003828 RID: 14376 RVA: 0x00113FFC File Offset: 0x001121FC
			// (set) Token: 0x06003829 RID: 14377 RVA: 0x00013686 File Offset: 0x00011886
			public unsafe UpdateLoopType updateLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_updateLoop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_updateLoop)) = value;
				}
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x0600382A RID: 14378 RVA: 0x00114024 File Offset: 0x00112224
			// (set) Token: 0x0600382B RID: 14379 RVA: 0x000136A1 File Offset: 0x000118A1
			public unsafe Il2CppStructArray<bool> values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BC RID: 4284
			// (get) Token: 0x0600382C RID: 14380 RVA: 0x00114054 File Offset: 0x00112254
			// (set) Token: 0x0600382D RID: 14381 RVA: 0x000136C0 File Offset: 0x000118C0
			public unsafe Il2CppStructArray<bool> wasTrueThisFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_wasTrueThisFrame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_wasTrueThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BD RID: 4285
			// (get) Token: 0x0600382E RID: 14382 RVA: 0x00114084 File Offset: 0x00112284
			// (set) Token: 0x0600382F RID: 14383 RVA: 0x000136DF File Offset: 0x000118DF
			public unsafe Il2CppStructArray<bool> NZXsgdVvVxkkVIMMsgAUhTNzlXJr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_NZXsgdVvVxkkVIMMsgAUhTNzlXJr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_NZXsgdVvVxkkVIMMsgAUhTNzlXJr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BE RID: 4286
			// (get) Token: 0x06003830 RID: 14384 RVA: 0x001140B4 File Offset: 0x001122B4
			// (set) Token: 0x06003831 RID: 14385 RVA: 0x000136FE File Offset: 0x000118FE
			public unsafe int YWoYmKEfatLPRZrbjKiKHLvQPXl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_YWoYmKEfatLPRZrbjKiKHLvQPXl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_YWoYmKEfatLPRZrbjKiKHLvQPXl)) = value;
				}
			}

			// Token: 0x170010BF RID: 4287
			// (get) Token: 0x06003832 RID: 14386 RVA: 0x001140DC File Offset: 0x001122DC
			// (set) Token: 0x06003833 RID: 14387 RVA: 0x00013719 File Offset: 0x00011919
			public unsafe Il2CppStructArray<bool> ltEmHoALiripIkSEjwFjPQQZVaVQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_ltEmHoALiripIkSEjwFjPQQZVaVQ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_ltEmHoALiripIkSEjwFjPQQZVaVQ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C0 RID: 4288
			// (get) Token: 0x06003834 RID: 14388 RVA: 0x0011410C File Offset: 0x0011230C
			// (set) Token: 0x06003835 RID: 14389 RVA: 0x00013738 File Offset: 0x00011938
			public unsafe Il2CppStructArray<bool> AczkMBDvBRgsizmVQODFflyexlg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_AczkMBDvBRgsizmVQODFflyexlg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonLoopSet.ButtonData.NativeFieldInfoPtr_AczkMBDvBRgsizmVQODFflyexlg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F53 RID: 12115
			private static readonly IntPtr NativeFieldInfoPtr_updateLoop;

			// Token: 0x04002F54 RID: 12116
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x04002F55 RID: 12117
			private static readonly IntPtr NativeFieldInfoPtr_wasTrueThisFrame;

			// Token: 0x04002F56 RID: 12118
			private static readonly IntPtr NativeFieldInfoPtr_NZXsgdVvVxkkVIMMsgAUhTNzlXJr;

			// Token: 0x04002F57 RID: 12119
			private static readonly IntPtr NativeFieldInfoPtr_YWoYmKEfatLPRZrbjKiKHLvQPXl;

			// Token: 0x04002F58 RID: 12120
			private static readonly IntPtr NativeFieldInfoPtr_ltEmHoALiripIkSEjwFjPQQZVaVQ;

			// Token: 0x04002F59 RID: 12121
			private static readonly IntPtr NativeFieldInfoPtr_AczkMBDvBRgsizmVQODFflyexlg;

			// Token: 0x04002F5A RID: 12122
			private static readonly IntPtr NativeMethodInfoPtr_get_effectiveValue_Public_get_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04002F5B RID: 12123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UpdateLoopType_0;

			// Token: 0x04002F5C RID: 12124
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0;

			// Token: 0x04002F5D RID: 12125
			private static readonly IntPtr NativeMethodInfoPtr_ClearWasTrueThisFrame_Public_Void_0;

			// Token: 0x04002F5E RID: 12126
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x04002F5F RID: 12127
			private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_ButtonData_0;

			// Token: 0x04002F60 RID: 12128
			private static readonly IntPtr NativeMethodInfoPtr_aBtBcSNInIxMETcIBoKxcEWHXSw_Private_Void_0;
		}
	}
}
