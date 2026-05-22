using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Drivers.Interfaces;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired.ControllerExtensions
{
	// Token: 0x0200006A RID: 106
	public sealed class RailDriverExtension : Controller.Extension
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x00063D8C File Offset: 0x00061F8C
		// Note: this type is marked as 'beforefieldinit'.
		static RailDriverExtension()
		{
			Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ControllerExtensions", "RailDriverExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr);
			RailDriverExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, "biBJftmjAXeWoBqMpeqfZEjZwtg");
			RailDriverExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665641);
			RailDriverExtension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_RailDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665642);
			RailDriverExtension.NativeMethodInfoPtr__ctor_Private_Void_RailDriverExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665643);
			RailDriverExtension.NativeMethodInfoPtr_get_speakerEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665644);
			RailDriverExtension.NativeMethodInfoPtr_set_speakerEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665645);
			RailDriverExtension.NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665646);
			RailDriverExtension.NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665647);
			RailDriverExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665648);
			RailDriverExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665649);
			RailDriverExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, 100665650);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00063E98 File Offset: 0x00062098
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256537, XrefRangeEnd = 256539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00063ED8 File Offset: 0x000620D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256539, XrefRangeEnd = 256543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RailDriverExtension(IDriver_RailDriver driver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr__ctor_Internal_Void_IDriver_RailDriver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00063F24 File Offset: 0x00062124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RailDriverExtension(RailDriverExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr__ctor_Private_Void_RailDriverExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00063F70 File Offset: 0x00062170
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00063FAC File Offset: 0x000621AC
		public unsafe bool speakerEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256543, XrefRangeEnd = 256552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_get_speakerEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256552, XrefRangeEnd = 256561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_set_speakerEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00063FEC File Offset: 0x000621EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256561, XrefRangeEnd = 256573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digitIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitBitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00064038 File Offset: 0x00062238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256573, XrefRangeEnd = 256585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit1BitValues;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit2BitValues;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit3BitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00064094 File Offset: 0x00062294
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000640D4 File Offset: 0x000622D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256585, XrefRangeEnd = 256589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SouFSqCHNLMbAzpFusEqgKLXdOQA(IControllerExtensionSource A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00064118 File Offset: 0x00062318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256589, XrefRangeEnd = 256593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00006FC6 File Offset: 0x000051C6
		public RailDriverExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00064158 File Offset: 0x00062358
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00006FCF File Offset: 0x000051CF
		public unsafe RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM biBJftmjAXeWoBqMpeqfZEjZwtg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IDriver_RailDriver_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RailDriverExtension_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_get_speakerEnabled_Public_get_Boolean_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_set_speakerEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Int32_Byte_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Void_Byte_Byte_Byte_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x02000287 RID: 647
		public class bAgHkMAQOkoKCRsJHeAFbygdqDsM : Object
		{
			// Token: 0x06003B0D RID: 15117 RVA: 0x0011CF28 File Offset: 0x0011B128
			// Note: this type is marked as 'beforefieldinit'.
			static bAgHkMAQOkoKCRsJHeAFbygdqDsM()
			{
				Il2CppClassPointerStore<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RailDriverExtension>.NativeClassPtr, "bAgHkMAQOkoKCRsJHeAFbygdqDsM");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>.NativeClassPtr);
				RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>.NativeClassPtr, "KawCpyGLfFBlzjAnKPJqxvWBPnRO");
				RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM.NativeMethodInfoPtr__ctor_Public_Void_IDriver_RailDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>.NativeClassPtr, 100665651);
			}

			// Token: 0x06003B0E RID: 15118 RVA: 0x0011CF7C File Offset: 0x0011B17C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bAgHkMAQOkoKCRsJHeAFbygdqDsM(IDriver_RailDriver driver)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM.NativeMethodInfoPtr__ctor_Public_Void_IDriver_RailDriver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003B0F RID: 15119 RVA: 0x00014F86 File Offset: 0x00013186
			public bAgHkMAQOkoKCRsJHeAFbygdqDsM(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C8 RID: 4552
			// (get) Token: 0x06003B10 RID: 15120 RVA: 0x0011CFC8 File Offset: 0x0011B1C8
			// (set) Token: 0x06003B11 RID: 15121 RVA: 0x00014F8F File Offset: 0x0001318F
			public unsafe IDriver_RailDriver KawCpyGLfFBlzjAnKPJqxvWBPnRO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDriver_RailDriver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverExtension.bAgHkMAQOkoKCRsJHeAFbygdqDsM.NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400318E RID: 12686
			private static readonly IntPtr NativeFieldInfoPtr_KawCpyGLfFBlzjAnKPJqxvWBPnRO;

			// Token: 0x0400318F RID: 12687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDriver_RailDriver_0;
		}
	}
}
