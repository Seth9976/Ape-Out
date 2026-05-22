using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Burst.LowLevel
{
	// Token: 0x0200003A RID: 58
	public static class BurstCompilerService : global::Il2CppSystem.Object
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00019234 File Offset: 0x00017434
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompilerService()
		{
			Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst.LowLevel", "BurstCompilerService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr);
			BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663409);
			BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663410);
			BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663411);
			BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663412);
			BurstCompilerService.GetDisassemblyDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetDisassemblyDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly");
			BurstCompilerService.GetMethodSignatureDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetMethodSignatureDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature");
			BurstCompilerService.get_IsInitializedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");
			BurstCompilerService.SetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.SetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode");
			BurstCompilerService.GetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode");
			BurstCompilerService.LoadBurstLibraryDelegateField = IL2CPP.ResolveICall<BurstCompilerService.LoadBurstLibraryDelegate>("Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary");
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00019310 File Offset: 0x00017510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485944, RefRangeEnd = 485945, XrefRangeStart = 485940, XrefRangeEnd = 485944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompileAsyncDelegateMethod(global::Il2CppSystem.Object delegateMethod, string compilerOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00019364 File Offset: 0x00017564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485949, RefRangeEnd = 485950, XrefRangeStart = 485945, XrefRangeEnd = 485949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00019398 File Offset: 0x00017598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485950, XrefRangeEnd = 485954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedMemory(ref global::UnityEngine.Hash128 key, uint size_of, uint alignment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size_of;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000193E8 File Offset: 0x000175E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485954, XrefRangeEnd = 485958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = message;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filename;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00003198 File Offset: 0x00001398
		public BurstCompilerService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00019450 File Offset: 0x00017650
		public static string GetDisassembly(MethodInfo m, string compilerOptions)
		{
			IntPtr intPtr = BurstCompilerService.GetDisassemblyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(m), IL2CPP.ManagedStringToIl2Cpp(compilerOptions));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001947C File Offset: 0x0001767C
		public static string GetMethodSignature(MethodInfo method)
		{
			IntPtr intPtr = BurstCompilerService.GetMethodSignatureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000031A1 File Offset: 0x000013A1
		public static bool IsInitialized
		{
			get
			{
				return BurstCompilerService.get_IsInitializedDelegateField();
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000031AD File Offset: 0x000013AD
		public static void SetCurrentExecutionMode(uint environment)
		{
			BurstCompilerService.SetCurrentExecutionModeDelegateField(environment);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000031BA File Offset: 0x000013BA
		public static uint GetCurrentExecutionMode()
		{
			return BurstCompilerService.GetCurrentExecutionModeDelegateField();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000031C6 File Offset: 0x000013C6
		public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
		{
			return BurstCompilerService.LoadBurstLibraryDelegateField(IL2CPP.ManagedStringToIl2Cpp(fullPathToLibBurstGenerated));
		}

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000111 RID: 273
		private static readonly BurstCompilerService.GetDisassemblyDelegate GetDisassemblyDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly BurstCompilerService.GetMethodSignatureDelegate GetMethodSignatureDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly BurstCompilerService.get_IsInitializedDelegate get_IsInitializedDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly BurstCompilerService.SetCurrentExecutionModeDelegate SetCurrentExecutionModeDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly BurstCompilerService.GetCurrentExecutionModeDelegate GetCurrentExecutionModeDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly BurstCompilerService.LoadBurstLibraryDelegate LoadBurstLibraryDelegateField;

		// Token: 0x0200032E RID: 814
		[OriginalName("UnityEngine.CoreModule.dll", "", "BurstLogType")]
		public enum BurstLogType
		{
			// Token: 0x04001E84 RID: 7812
			Info,
			// Token: 0x04001E85 RID: 7813
			Warning,
			// Token: 0x04001E86 RID: 7814
			Error
		}

		// Token: 0x0200032F RID: 815
		// (Invoke) Token: 0x06002477 RID: 9335
		private delegate IntPtr GetDisassemblyDelegate(IntPtr m, IntPtr compilerOptions);

		// Token: 0x02000330 RID: 816
		// (Invoke) Token: 0x06002479 RID: 9337
		private delegate IntPtr GetMethodSignatureDelegate(IntPtr method);

		// Token: 0x02000331 RID: 817
		// (Invoke) Token: 0x0600247B RID: 9339
		private delegate bool get_IsInitializedDelegate();

		// Token: 0x02000332 RID: 818
		// (Invoke) Token: 0x0600247D RID: 9341
		private delegate void SetCurrentExecutionModeDelegate(uint environment);

		// Token: 0x02000333 RID: 819
		// (Invoke) Token: 0x0600247F RID: 9343
		private delegate uint GetCurrentExecutionModeDelegate();

		// Token: 0x02000334 RID: 820
		// (Invoke) Token: 0x06002481 RID: 9345
		private delegate bool LoadBurstLibraryDelegate(IntPtr fullPathToLibBurstGenerated);
	}
}
