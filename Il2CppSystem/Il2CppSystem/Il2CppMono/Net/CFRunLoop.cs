using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x02000014 RID: 20
	public class CFRunLoop : CFObject
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00013774 File Offset: 0x00011974
		// Note: this type is marked as 'beforefieldinit'.
		static CFRunLoop()
		{
			Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFRunLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr);
			CFRunLoop.NativeMethodInfoPtr_CFRunLoopAddSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663540);
			CFRunLoop.NativeMethodInfoPtr_CFRunLoopRemoveSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663541);
			CFRunLoop.NativeMethodInfoPtr_CFRunLoopRunInMode_Private_Static_Int32_IntPtr_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663542);
			CFRunLoop.NativeMethodInfoPtr_CFRunLoopGetCurrent_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663543);
			CFRunLoop.NativeMethodInfoPtr_CFRunLoopStop_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663544);
			CFRunLoop.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663545);
			CFRunLoop.NativeMethodInfoPtr_get_CurrentRunLoop_Public_Static_get_CFRunLoop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663546);
			CFRunLoop.NativeMethodInfoPtr_AddSource_Public_Void_IntPtr_CFString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663547);
			CFRunLoop.NativeMethodInfoPtr_RemoveSource_Public_Void_IntPtr_CFString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663548);
			CFRunLoop.NativeMethodInfoPtr_RunInMode_Public_Int32_CFString_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663549);
			CFRunLoop.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr, 100663550);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00013880 File Offset: 0x00011A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365043, XrefRangeEnd = 365045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_CFRunLoopAddSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000138D0 File Offset: 0x00011AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365045, XrefRangeEnd = 365047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_CFRunLoopRemoveSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00013920 File Offset: 0x00011B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365047, XrefRangeEnd = 365049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnAfterSourceHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_CFRunLoopRunInMode_Private_Static_Int32_IntPtr_Double_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001397C File Offset: 0x00011B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365049, XrefRangeEnd = 365051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFRunLoopGetCurrent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_CFRunLoopGetCurrent_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000139AC File Offset: 0x00011BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365051, XrefRangeEnd = 365053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFRunLoopStop(IntPtr rl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_CFRunLoopStop_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000139E0 File Offset: 0x00011BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFRunLoop(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFRunLoop>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00013A38 File Offset: 0x00011C38
		public unsafe static CFRunLoop CurrentRunLoop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365053, XrefRangeEnd = 365060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_get_CurrentRunLoop_Public_Static_get_CFRunLoop_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFRunLoop>(intPtr3) : null;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00013A6C File Offset: 0x00011C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365060, XrefRangeEnd = 365063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSource(IntPtr source, CFString mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_AddSource_Public_Void_IntPtr_CFString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00013ABC File Offset: 0x00011CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365063, XrefRangeEnd = 365066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSource(IntPtr source, CFString mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_RemoveSource_Public_Void_IntPtr_CFString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00013B0C File Offset: 0x00011D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365066, XrefRangeEnd = 365069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnAfterSourceHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_RunInMode_Public_Int32_CFString_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00013B78 File Offset: 0x00011D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365069, XrefRangeEnd = 365071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRunLoop.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000243B File Offset: 0x0000063B
		public CFRunLoop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_CFRunLoopAddSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_CFRunLoopRemoveSource_Private_Static_Void_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_CFRunLoopRunInMode_Private_Static_Int32_IntPtr_Double_Boolean_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_CFRunLoopGetCurrent_Private_Static_IntPtr_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_CFRunLoopStop_Private_Static_Void_IntPtr_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRunLoop_Public_Static_get_CFRunLoop_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Void_IntPtr_CFString_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Void_IntPtr_CFString_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_RunInMode_Public_Int32_CFString_Double_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
	}
}
