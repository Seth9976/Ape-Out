using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000110 RID: 272
	public static class Console : Object
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x00080B6C File Offset: 0x0007ED6C
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Console");
			Console.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdout");
			Console.NativeFieldInfoPtr_stderr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stderr");
			Console.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdin");
			Console.NativeFieldInfoPtr_inputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "inputEncoding");
			Console.NativeFieldInfoPtr_outputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "outputEncoding");
			Console.NativeFieldInfoPtr_cancel_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_event");
			Console.NativeFieldInfoPtr_cancel_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_handler");
			Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666802);
			Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666803);
			Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666804);
			Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666805);
			Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666806);
			Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666807);
			Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666808);
			Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666809);
			Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666810);
			Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666811);
			Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666812);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666813);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666814);
			Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666815);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00080D38 File Offset: 0x0007EF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174542, XrefRangeEnd = 174601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputEncoding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputEncoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00080D80 File Offset: 0x0007EF80
		public unsafe static TextWriter Error
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174601, XrefRangeEnd = 174605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00080DB4 File Offset: 0x0007EFB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174615, RefRangeEnd = 174618, XrefRangeStart = 174605, XrefRangeEnd = 174615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00080E10 File Offset: 0x0007F010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174625, RefRangeEnd = 174626, XrefRangeStart = 174618, XrefRangeEnd = 174625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardError(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00080E50 File Offset: 0x0007F050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174633, RefRangeEnd = 174635, XrefRangeStart = 174626, XrefRangeEnd = 174633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardInput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00080E90 File Offset: 0x0007F090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174642, RefRangeEnd = 174643, XrefRangeStart = 174635, XrefRangeEnd = 174642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardOutput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00080ED0 File Offset: 0x0007F0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174643, XrefRangeEnd = 174647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOut(TextWriter newOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00080F08 File Offset: 0x0007F108
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174652, RefRangeEnd = 174658, XrefRangeStart = 174647, XrefRangeEnd = 174652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteLine(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00080F40 File Offset: 0x0007F140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174658, XrefRangeEnd = 174663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteLine(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00080F78 File Offset: 0x0007F178
		public unsafe static Encoding InputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174663, XrefRangeEnd = 174667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00080FAC File Offset: 0x0007F1AC
		public unsafe static Encoding OutputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174667, XrefRangeEnd = 174671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00080FE0 File Offset: 0x0007F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174671, XrefRangeEnd = 174685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00081010 File Offset: 0x0007F210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174685, XrefRangeEnd = 174696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00081050 File Offset: 0x0007F250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174714, RefRangeEnd = 174715, XrefRangeStart = 174696, XrefRangeEnd = 174714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoConsoleCancelEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00006EDA File Offset: 0x000050DA
		public Console(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00081078 File Offset: 0x0007F278
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x00006EE3 File Offset: 0x000050E3
		public unsafe static TextWriter stdout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdout, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdout, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x000810A0 File Offset: 0x0007F2A0
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x00006EF5 File Offset: 0x000050F5
		public unsafe static TextWriter stderr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stderr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stderr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x000810C8 File Offset: 0x0007F2C8
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x00006F07 File Offset: 0x00005107
		public unsafe static TextReader stdin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000810F0 File Offset: 0x0007F2F0
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x00006F19 File Offset: 0x00005119
		public unsafe static Encoding inputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_inputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_inputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00081118 File Offset: 0x0007F318
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00006F2B File Offset: 0x0000512B
		public unsafe static Encoding outputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_outputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_outputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00081140 File Offset: 0x0007F340
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x00006F3D File Offset: 0x0000513D
		public unsafe static ConsoleCancelEventHandler cancel_event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_cancel_event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsoleCancelEventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_cancel_event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00081168 File Offset: 0x0007F368
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00006F4F File Offset: 0x0000514F
		public unsafe static Console.InternalCancelHandler cancel_handler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_cancel_handler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Console.InternalCancelHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_cancel_handler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_stderr;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr_inputEncoding;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_outputEncoding;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_cancel_event;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr_cancel_handler;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Static_Void_Object_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0;

		// Token: 0x020005AA RID: 1450
		public class WindowsConsole : Object
		{
			// Token: 0x06005133 RID: 20787 RVA: 0x00170290 File Offset: 0x0016E490
			// Note: this type is marked as 'beforefieldinit'.
			static WindowsConsole()
			{
				Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "WindowsConsole");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr);
				Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "ctrlHandlerAdded");
				Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "cancelHandler");
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666816);
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666817);
				Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666818);
				Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666819);
				Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666820);
			}

			// Token: 0x06005134 RID: 20788 RVA: 0x00170348 File Offset: 0x0016E548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174516, XrefRangeEnd = 174518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005135 RID: 20789 RVA: 0x00170378 File Offset: 0x0016E578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174518, XrefRangeEnd = 174520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleOutputCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005136 RID: 20790 RVA: 0x001703A8 File Offset: 0x0016E5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174520, XrefRangeEnd = 174524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref keyCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005137 RID: 20791 RVA: 0x001703E8 File Offset: 0x0016E5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174524, XrefRangeEnd = 174529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetInputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005138 RID: 20792 RVA: 0x00170418 File Offset: 0x0016E618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174529, XrefRangeEnd = 174542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetOutputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005139 RID: 20793 RVA: 0x0001E711 File Offset: 0x0001C911
			public WindowsConsole(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014C1 RID: 5313
			// (get) Token: 0x0600513A RID: 20794 RVA: 0x00170448 File Offset: 0x0016E648
			// (set) Token: 0x0600513B RID: 20795 RVA: 0x0001E71A File Offset: 0x0001C91A
			public unsafe static bool ctrlHandlerAdded
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&value));
				}
			}

			// Token: 0x170014C2 RID: 5314
			// (get) Token: 0x0600513C RID: 20796 RVA: 0x00170464 File Offset: 0x0016E664
			// (set) Token: 0x0600513D RID: 20797 RVA: 0x0001E728 File Offset: 0x0001C928
			public unsafe static Console.WindowsConsole.WindowsCancelHandler cancelHandler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Console.WindowsConsole.WindowsCancelHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004225 RID: 16933
			private static readonly IntPtr NativeFieldInfoPtr_ctrlHandlerAdded;

			// Token: 0x04004226 RID: 16934
			private static readonly IntPtr NativeFieldInfoPtr_cancelHandler;

			// Token: 0x04004227 RID: 16935
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0;

			// Token: 0x04004228 RID: 16936
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0;

			// Token: 0x04004229 RID: 16937
			private static readonly IntPtr NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0;

			// Token: 0x0400422A RID: 16938
			private static readonly IntPtr NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0;

			// Token: 0x0400422B RID: 16939
			private static readonly IntPtr NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0;

			// Token: 0x020006CC RID: 1740
			public sealed class WindowsCancelHandler : MulticastDelegate
			{
				// Token: 0x060059B5 RID: 22965 RVA: 0x0018C6FC File Offset: 0x0018A8FC
				// Note: this type is marked as 'beforefieldinit'.
				static WindowsCancelHandler()
				{
					Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "WindowsCancelHandler");
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666822);
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666823);
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666824);
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666825);
				}

				// Token: 0x060059B6 RID: 22966 RVA: 0x0018C770 File Offset: 0x0018A970
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WindowsCancelHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059B7 RID: 22967 RVA: 0x0018C7CC File Offset: 0x0018A9CC
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 174497, RefRangeEnd = 174512, XrefRangeStart = 174497, XrefRangeEnd = 174497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool Invoke(int keyCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref keyCode;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060059B8 RID: 22968 RVA: 0x0018C818 File Offset: 0x0018AA18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174512, XrefRangeEnd = 174516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref keyCode;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060059B9 RID: 22969 RVA: 0x0018C888 File Offset: 0x0018AA88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060059BA RID: 22970 RVA: 0x00022AC8 File Offset: 0x00020CC8
				public WindowsCancelHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060059BB RID: 22971 RVA: 0x00022AD1 File Offset: 0x00020CD1
				public static implicit operator Console.WindowsConsole.WindowsCancelHandler(Func<int, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<Console.WindowsConsole.WindowsCancelHandler>(A_0);
				}

				// Token: 0x060059BC RID: 22972 RVA: 0x00022AD9 File Offset: 0x00020CD9
				public static Console.WindowsConsole.WindowsCancelHandler operator +(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Console.WindowsConsole.WindowsCancelHandler>();
				}

				// Token: 0x060059BD RID: 22973 RVA: 0x00022AE7 File Offset: 0x00020CE7
				public static Console.WindowsConsole.WindowsCancelHandler operator -(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Console.WindowsConsole.WindowsCancelHandler>();
					}
					return delegate2;
				}

				// Token: 0x040047A7 RID: 18343
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040047A8 RID: 18344
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0;

				// Token: 0x040047A9 RID: 18345
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

				// Token: 0x040047AA RID: 18346
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}
		}

		// Token: 0x020005AB RID: 1451
		public sealed class InternalCancelHandler : MulticastDelegate
		{
			// Token: 0x0600513E RID: 20798 RVA: 0x0017048C File Offset: 0x0016E68C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalCancelHandler()
			{
				Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "InternalCancelHandler");
				Console.InternalCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666826);
				Console.InternalCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666827);
				Console.InternalCancelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666828);
				Console.InternalCancelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666829);
			}

			// Token: 0x0600513F RID: 20799 RVA: 0x00170500 File Offset: 0x0016E700
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalCancelHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005140 RID: 20800 RVA: 0x0017055C File Offset: 0x0016E75C
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005141 RID: 20801 RVA: 0x00170590 File Offset: 0x0016E790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005142 RID: 20802 RVA: 0x001705F4 File Offset: 0x0016E7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005143 RID: 20803 RVA: 0x0001E73A File Offset: 0x0001C93A
			public InternalCancelHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005144 RID: 20804 RVA: 0x0001E743 File Offset: 0x0001C943
			public static implicit operator Console.InternalCancelHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Console.InternalCancelHandler>(A_0);
			}

			// Token: 0x06005145 RID: 20805 RVA: 0x0001E74B File Offset: 0x0001C94B
			public static Console.InternalCancelHandler operator +(Console.InternalCancelHandler A_0, Console.InternalCancelHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Console.InternalCancelHandler>();
			}

			// Token: 0x06005146 RID: 20806 RVA: 0x0001E759 File Offset: 0x0001C959
			public static Console.InternalCancelHandler operator -(Console.InternalCancelHandler A_0, Console.InternalCancelHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Console.InternalCancelHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400422C RID: 16940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400422D RID: 16941
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400422E RID: 16942
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400422F RID: 16943
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
