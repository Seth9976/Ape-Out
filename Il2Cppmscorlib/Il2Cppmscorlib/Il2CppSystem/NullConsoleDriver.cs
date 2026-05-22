using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000127 RID: 295
	public class NullConsoleDriver : Object
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x0008469C File Offset: 0x0008289C
		// Note: this type is marked as 'beforefieldinit'.
		static NullConsoleDriver()
		{
			Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr);
			NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, "EmptyConsoleKeyInfo");
			NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100666949);
			NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100666950);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00084708 File Offset: 0x00082908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176109, XrefRangeEnd = 176113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00084754 File Offset: 0x00082954
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000073BE File Offset: 0x000055BE
		public NullConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00084790 File Offset: 0x00082990
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x000073C7 File Offset: 0x000055C7
		public unsafe static ConsoleKeyInfo EmptyConsoleKeyInfo
		{
			get
			{
				ConsoleKeyInfo consoleKeyInfo;
				IL2CPP.il2cpp_field_static_get_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&consoleKeyInfo));
				return consoleKeyInfo;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&value));
			}
		}

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeFieldInfoPtr_EmptyConsoleKeyInfo;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
