using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BE RID: 1214
	public sealed class Debugger : Object
	{
		// Token: 0x060048D4 RID: 18644 RVA: 0x00151A04 File Offset: 0x0014FC04
		// Note: this type is marked as 'beforefieldinit'.
		static Debugger()
		{
			Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "Debugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
			Debugger.NativeFieldInfoPtr_DefaultCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "DefaultCategory");
			Debugger.NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674207);
			Debugger.NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674208);
			Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674209);
			Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674210);
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x00151A98 File Offset: 0x0014FC98
		public unsafe static bool IsAttached
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233219, XrefRangeEnd = 233222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00151AC8 File Offset: 0x0014FCC8
		[CallerCount(0)]
		public unsafe static bool IsAttached_internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00151AF8 File Offset: 0x0014FCF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(int level, string category, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00151B50 File Offset: 0x0014FD50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyOfCrossThreadDependency()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0001B358 File Offset: 0x00019558
		public Debugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x00151B78 File Offset: 0x0014FD78
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x0001B361 File Offset: 0x00019561
		public unsafe static string DefaultCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr_DefaultCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr_DefaultCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCategory;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0;

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0;
	}
}
