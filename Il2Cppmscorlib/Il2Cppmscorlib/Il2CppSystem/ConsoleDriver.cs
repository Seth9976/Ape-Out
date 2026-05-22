using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000111 RID: 273
	public static class ConsoleDriver : Object
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x00081190 File Offset: 0x0007F390
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleDriver()
		{
			Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleDriver");
			ConsoleDriver.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "driver");
			ConsoleDriver.NativeFieldInfoPtr_is_console = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "is_console");
			ConsoleDriver.NativeFieldInfoPtr_called_isatty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "called_isatty");
			ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666831);
			ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666832);
			ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666833);
			ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666834);
			ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666835);
			ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666836);
			ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666837);
			ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666838);
			ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100666839);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000812A8 File Offset: 0x0007F4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174718, RefRangeEnd = 174719, XrefRangeStart = 174715, XrefRangeEnd = 174718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateNullConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000812DC File Offset: 0x0007F4DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174727, RefRangeEnd = 174728, XrefRangeStart = 174719, XrefRangeEnd = 174727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateWindowsConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00081310 File Offset: 0x0007F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174728, XrefRangeEnd = 174732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateTermInfoDriver(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00081354 File Offset: 0x0007F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174732, XrefRangeEnd = 174739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00081394 File Offset: 0x0007F594
		public unsafe static bool IsConsole
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 174758, RefRangeEnd = 174760, XrefRangeStart = 174739, XrefRangeEnd = 174758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000813C4 File Offset: 0x0007F5C4
		[CallerCount(0)]
		public unsafe static bool Isatty(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00081404 File Offset: 0x0007F604
		[CallerCount(0)]
		public unsafe static int InternalKeyAvailable(int ms_timeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ms_timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00081444 File Offset: 0x0007F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174760, XrefRangeEnd = 174761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TtySetup(string keypadXmit, string teardown, out Il2CppStructArray<byte> control_characters, out int* address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keypadXmit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(teardown);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			control_characters = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			address = ((intPtr6 == 0) ? null : new int*(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000814E0 File Offset: 0x0007F6E0
		[CallerCount(0)]
		public unsafe static bool SetEcho(bool wantEcho)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wantEcho;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00006F61 File Offset: 0x00005161
		public ConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00081520 File Offset: 0x0007F720
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x00006F6A File Offset: 0x0000516A
		public unsafe static IConsoleDriver driver
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_driver, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_driver, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00081548 File Offset: 0x0007F748
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x00006F7C File Offset: 0x0000517C
		public unsafe static bool is_console
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00081564 File Offset: 0x0007F764
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00006F8A File Offset: 0x0000518A
		public unsafe static bool called_isatty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&value));
			}
		}

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_is_console;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_called_isatty;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0;
	}
}
