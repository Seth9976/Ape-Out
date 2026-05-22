using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem
{
	// Token: 0x02000135 RID: 309
	public class TermInfoDriver : Object
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x00089234 File Offset: 0x00087434
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoDriver()
		{
			Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr);
			TermInfoDriver.NativeFieldInfoPtr_native_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "native_terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "locations");
			TermInfoDriver.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "reader");
			TermInfoDriver.NativeFieldInfoPtr_cursorLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorLeft");
			TermInfoDriver.NativeFieldInfoPtr_cursorTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorTop");
			TermInfoDriver.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "title");
			TermInfoDriver.NativeFieldInfoPtr_titleFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "titleFormat");
			TermInfoDriver.NativeFieldInfoPtr_cursorVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrInvisible");
			TermInfoDriver.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "clear");
			TermInfoDriver.NativeFieldInfoPtr_bell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bell");
			TermInfoDriver.NativeFieldInfoPtr_term = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "term");
			TermInfoDriver.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdin");
			TermInfoDriver.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdout");
			TermInfoDriver.NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowWidth");
			TermInfoDriver.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferWidth");
			TermInfoDriver.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "buffer");
			TermInfoDriver.NativeFieldInfoPtr_readpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "readpos");
			TermInfoDriver.NativeFieldInfoPtr_writepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "writepos");
			TermInfoDriver.NativeFieldInfoPtr_keypadXmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadXmit");
			TermInfoDriver.NativeFieldInfoPtr_keypadLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadLocal");
			TermInfoDriver.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "inited");
			TermInfoDriver.NativeFieldInfoPtr_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initLock");
			TermInfoDriver.NativeFieldInfoPtr_initKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initKeys");
			TermInfoDriver.NativeFieldInfoPtr_origPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origPair");
			TermInfoDriver.NativeFieldInfoPtr_origColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origColors");
			TermInfoDriver.NativeFieldInfoPtr_cursorAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorAddress");
			TermInfoDriver.NativeFieldInfoPtr_fgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "fgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setfgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setfgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setbgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setbgcolor");
			TermInfoDriver.NativeFieldInfoPtr_maxColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "maxColors");
			TermInfoDriver.NativeFieldInfoPtr_noGetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "noGetPosition");
			TermInfoDriver.NativeFieldInfoPtr_keymap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keymap");
			TermInfoDriver.NativeFieldInfoPtr_rootmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rootmap");
			TermInfoDriver.NativeFieldInfoPtr_rl_startx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_startx");
			TermInfoDriver.NativeFieldInfoPtr_rl_starty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_starty");
			TermInfoDriver.NativeFieldInfoPtr_control_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "control_characters");
			TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "_consoleColorToAnsiCode");
			TermInfoDriver.NativeFieldInfoPtr_echobuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echobuf");
			TermInfoDriver.NativeFieldInfoPtr_echon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echon");
			TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667127);
			TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667128);
			TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667129);
			TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667130);
			TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667131);
			TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667132);
			TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667133);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667134);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667135);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667136);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667137);
			TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667138);
			TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667139);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667140);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667141);
			TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667142);
			TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667143);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667144);
			TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667145);
			TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667146);
			TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667147);
			TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667148);
			TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667149);
			TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667150);
			TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667151);
			TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667152);
			TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667153);
			TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667154);
			TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667155);
			TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667156);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667157);
			TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667158);
			TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667159);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00089868 File Offset: 0x00087A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177496, RefRangeEnd = 177498, XrefRangeStart = 177483, XrefRangeEnd = 177496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryTermInfoDir(string dir, string term)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(term);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000898B8 File Offset: 0x00087AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177516, RefRangeEnd = 177517, XrefRangeStart = 177498, XrefRangeEnd = 177516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SearchTerminfo(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000898F4 File Offset: 0x00087AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177517, XrefRangeEnd = 177518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteConsole(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00089938 File Offset: 0x00087B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177576, RefRangeEnd = 177577, XrefRangeStart = 177518, XrefRangeEnd = 177576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoDriver(string term)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00089984 File Offset: 0x00087B84
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000899C0 File Offset: 0x00087BC0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 177671, RefRangeEnd = 177680, XrefRangeStart = 177577, XrefRangeEnd = 177671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000899F4 File Offset: 0x00087BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177680, XrefRangeEnd = 177684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00089A28 File Offset: 0x00087C28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177697, RefRangeEnd = 177701, XrefRangeStart = 177684, XrefRangeEnd = 177697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00089A68 File Offset: 0x00087C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177701, XrefRangeEnd = 177703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00089AA8 File Offset: 0x00087CA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177703, RefRangeEnd = 177707, XrefRangeStart = 177703, XrefRangeEnd = 177703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00089AF4 File Offset: 0x00087CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177707, XrefRangeEnd = 177709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00089B40 File Offset: 0x00087D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177718, RefRangeEnd = 177720, XrefRangeStart = 177709, XrefRangeEnd = 177718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCursorPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00089B74 File Offset: 0x00087D74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 177736, RefRangeEnd = 177743, XrefRangeStart = 177720, XrefRangeEnd = 177736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWindowDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00089BA8 File Offset: 0x00087DA8
		public unsafe virtual int WindowHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177743, XrefRangeEnd = 177745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00089BE4 File Offset: 0x00087DE4
		public unsafe virtual int WindowWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177745, XrefRangeEnd = 177747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00089C20 File Offset: 0x00087E20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177755, RefRangeEnd = 177758, XrefRangeStart = 177747, XrefRangeEnd = 177755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToBuffer(int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00089C60 File Offset: 0x00087E60
		[CallerCount(0)]
		public unsafe void AdjustBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00089C94 File Offset: 0x00087E94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 177766, RefRangeEnd = 177773, XrefRangeStart = 177758, XrefRangeEnd = 177766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00089CEC File Offset: 0x00087EEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177791, RefRangeEnd = 177796, XrefRangeStart = 177773, XrefRangeEnd = 177791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetKeyFromBuffer(bool cooked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cooked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00089D38 File Offset: 0x00087F38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177810, RefRangeEnd = 177813, XrefRangeStart = 177796, XrefRangeEnd = 177810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo ReadKeyInternal(out bool fresh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00089D84 File Offset: 0x00087F84
		[CallerCount(0)]
		public unsafe bool InputPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00089DC0 File Offset: 0x00087FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177813, XrefRangeEnd = 177817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueEcho(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00089E00 File Offset: 0x00088000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177820, RefRangeEnd = 177823, XrefRangeStart = 177817, XrefRangeEnd = 177820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Echo(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00089E40 File Offset: 0x00088040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177823, XrefRangeEnd = 177824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EchoFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00089E74 File Offset: 0x00088074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177848, RefRangeEnd = 177849, XrefRangeStart = 177824, XrefRangeEnd = 177848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read([In] [Out] Il2CppStructArray<char> dest, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00089EF0 File Offset: 0x000880F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177849, XrefRangeEnd = 177852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00089F3C File Offset: 0x0008813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177852, XrefRangeEnd = 177853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00089F74 File Offset: 0x00088174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177853, XrefRangeEnd = 177854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00089FAC File Offset: 0x000881AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177869, RefRangeEnd = 177873, XrefRangeStart = 177854, XrefRangeEnd = 177869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref haltOnNewLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00089FF0 File Offset: 0x000881F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177880, RefRangeEnd = 177882, XrefRangeStart = 177873, XrefRangeEnd = 177880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCursorPosition(int left, int top)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0008A03C File Offset: 0x0008823C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178130, RefRangeEnd = 178131, XrefRangeStart = 177882, XrefRangeEnd = 178130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateKeyMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0008A070 File Offset: 0x00088270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178155, RefRangeEnd = 178156, XrefRangeStart = 178131, XrefRangeEnd = 178155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0008A0A4 File Offset: 0x000882A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178156, XrefRangeEnd = 178158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStringMapping(TermInfoStrings s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00007821 File Offset: 0x00005A21
		public TermInfoDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0008A0E4 File Offset: 0x000882E4
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x0000782A File Offset: 0x00005A2A
		public unsafe static int* native_terminal_size
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)value);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x0008A100 File Offset: 0x00088300
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00007837 File Offset: 0x00005A37
		public unsafe static int terminal_size
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0008A11C File Offset: 0x0008831C
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00007845 File Offset: 0x00005A45
		public unsafe static Il2CppStringArray locations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_locations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_locations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0008A144 File Offset: 0x00088344
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00007857 File Offset: 0x00005A57
		public unsafe TermInfoReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0008A174 File Offset: 0x00088374
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00007876 File Offset: 0x00005A76
		public unsafe int cursorLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0008A19C File Offset: 0x0008839C
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00007891 File Offset: 0x00005A91
		public unsafe int cursorTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0008A1C4 File Offset: 0x000883C4
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x000078AC File Offset: 0x00005AAC
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0008A1EC File Offset: 0x000883EC
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x000078CB File Offset: 0x00005ACB
		public unsafe string titleFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0008A214 File Offset: 0x00088414
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x000078EA File Offset: 0x00005AEA
		public unsafe bool cursorVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0008A23C File Offset: 0x0008843C
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00007905 File Offset: 0x00005B05
		public unsafe string csrVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x0008A264 File Offset: 0x00088464
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x00007924 File Offset: 0x00005B24
		public unsafe string csrInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0008A28C File Offset: 0x0008848C
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x00007943 File Offset: 0x00005B43
		public unsafe string clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x0008A2B4 File Offset: 0x000884B4
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00007962 File Offset: 0x00005B62
		public unsafe string bell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0008A2DC File Offset: 0x000884DC
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00007981 File Offset: 0x00005B81
		public unsafe string term
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x0008A304 File Offset: 0x00088504
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x000079A0 File Offset: 0x00005BA0
		public unsafe StreamReader stdin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x0008A334 File Offset: 0x00088534
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x000079BF File Offset: 0x00005BBF
		public unsafe CStreamWriter stdout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CStreamWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x0008A364 File Offset: 0x00088564
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x000079DE File Offset: 0x00005BDE
		public unsafe int windowWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x0008A38C File Offset: 0x0008858C
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x000079F9 File Offset: 0x00005BF9
		public unsafe int windowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight)) = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x0008A3B4 File Offset: 0x000885B4
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00007A14 File Offset: 0x00005C14
		public unsafe int bufferHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight)) = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0008A3DC File Offset: 0x000885DC
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00007A2F File Offset: 0x00005C2F
		public unsafe int bufferWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x0008A404 File Offset: 0x00088604
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00007A4A File Offset: 0x00005C4A
		public unsafe Il2CppStructArray<char> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x0008A434 File Offset: 0x00088634
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00007A69 File Offset: 0x00005C69
		public unsafe int readpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x0008A45C File Offset: 0x0008865C
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00007A84 File Offset: 0x00005C84
		public unsafe int writepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0008A484 File Offset: 0x00088684
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00007A9F File Offset: 0x00005C9F
		public unsafe string keypadXmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0008A4AC File Offset: 0x000886AC
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00007ABE File Offset: 0x00005CBE
		public unsafe string keypadLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x0008A4D4 File Offset: 0x000886D4
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x00007ADD File Offset: 0x00005CDD
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x0008A4FC File Offset: 0x000886FC
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public unsafe Object initLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x0008A52C File Offset: 0x0008872C
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00007B17 File Offset: 0x00005D17
		public unsafe bool initKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys)) = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x0008A554 File Offset: 0x00088754
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00007B32 File Offset: 0x00005D32
		public unsafe string origPair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x0008A57C File Offset: 0x0008877C
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00007B51 File Offset: 0x00005D51
		public unsafe string origColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x0008A5A4 File Offset: 0x000887A4
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x00007B70 File Offset: 0x00005D70
		public unsafe string cursorAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x0008A5CC File Offset: 0x000887CC
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00007B8F File Offset: 0x00005D8F
		public unsafe ConsoleColor fgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x0008A5F4 File Offset: 0x000887F4
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x00007BAA File Offset: 0x00005DAA
		public unsafe string setfgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0008A61C File Offset: 0x0008881C
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x00007BC9 File Offset: 0x00005DC9
		public unsafe string setbgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x0008A644 File Offset: 0x00088844
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x00007BE8 File Offset: 0x00005DE8
		public unsafe int maxColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x0008A66C File Offset: 0x0008886C
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00007C03 File Offset: 0x00005E03
		public unsafe bool noGetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0008A694 File Offset: 0x00088894
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x00007C1E File Offset: 0x00005E1E
		public unsafe Hashtable keymap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0008A6C4 File Offset: 0x000888C4
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00007C3D File Offset: 0x00005E3D
		public unsafe ByteMatcher rootmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x0008A6F4 File Offset: 0x000888F4
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x00007C5C File Offset: 0x00005E5C
		public unsafe int rl_startx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0008A71C File Offset: 0x0008891C
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00007C77 File Offset: 0x00005E77
		public unsafe int rl_starty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty)) = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x00007C92 File Offset: 0x00005E92
		public unsafe Il2CppStructArray<byte> control_characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0008A774 File Offset: 0x00088974
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x00007CB1 File Offset: 0x00005EB1
		public unsafe static Il2CppStructArray<int> _consoleColorToAnsiCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0008A79C File Offset: 0x0008899C
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x00007CC3 File Offset: 0x00005EC3
		public unsafe Il2CppStructArray<char> echobuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0008A7CC File Offset: 0x000889CC
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00007CE2 File Offset: 0x00005EE2
		public unsafe int echon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon)) = value;
			}
		}

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeFieldInfoPtr_native_terminal_size;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeFieldInfoPtr_terminal_size;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeFieldInfoPtr_locations;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_cursorLeft;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeFieldInfoPtr_cursorTop;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_titleFormat;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_cursorVisible;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_csrVisible;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_csrInvisible;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_clear;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_bell;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_term;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_windowWidth;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeFieldInfoPtr_bufferHeight;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeFieldInfoPtr_bufferWidth;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeFieldInfoPtr_readpos;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeFieldInfoPtr_writepos;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeFieldInfoPtr_keypadXmit;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeFieldInfoPtr_keypadLocal;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeFieldInfoPtr_initLock;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_initKeys;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_origPair;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_origColors;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_cursorAddress;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_fgcolor;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_setfgcolor;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_setbgcolor;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_maxColors;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_noGetPosition;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_keymap;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_rootmap;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_rl_startx;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_rl_starty;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_control_characters;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr__consoleColorToAnsiCode;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_echobuf;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_echon;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeMethodInfoPtr_WriteConsole_Private_Void_String_0;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_IncrementX_Private_Void_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPosition_Private_Void_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBuffer_Private_Void_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_InputPending_Private_Boolean_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_EchoFlush_Private_Void_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_String_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyMap_Private_Void_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_InitKeys_Private_Void_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0;
	}
}
