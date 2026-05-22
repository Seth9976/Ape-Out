using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000153 RID: 339
	public class WindowsConsoleDriver : Object
	{
		// Token: 0x0600176D RID: 5997 RVA: 0x0008DB78 File Offset: 0x0008BD78
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsConsoleDriver()
		{
			Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WindowsConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr);
			WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "inputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "outputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "defaultAttribute");
			WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667276);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667277);
			WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667278);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667279);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667280);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667281);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0008DC5C File Offset: 0x0008BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178925, XrefRangeEnd = 178930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0008DC98 File Offset: 0x0008BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178930, XrefRangeEnd = 178934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0008DCE4 File Offset: 0x0008BEE4
		[CallerCount(0)]
		public unsafe static bool IsModifierKey(short virtualKeyCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref virtualKeyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0008DD24 File Offset: 0x0008BF24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178937, RefRangeEnd = 178941, XrefRangeStart = 178934, XrefRangeEnd = 178937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStdHandle(Handles handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0008DD64 File Offset: 0x0008BF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178941, XrefRangeEnd = 178944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0008DDB0 File Offset: 0x0008BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178944, XrefRangeEnd = 178947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &record;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00008231 File Offset: 0x00006431
		public WindowsConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0008DE18 File Offset: 0x0008C018
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x0000823A File Offset: 0x0000643A
		public unsafe IntPtr inputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle)) = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0008DE40 File Offset: 0x0008C040
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00008255 File Offset: 0x00006455
		public unsafe IntPtr outputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0008DE68 File Offset: 0x0008C068
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x00008270 File Offset: 0x00006470
		public unsafe short defaultAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute)) = value;
			}
		}

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_inputHandle;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr_outputHandle;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttribute;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0;
	}
}
