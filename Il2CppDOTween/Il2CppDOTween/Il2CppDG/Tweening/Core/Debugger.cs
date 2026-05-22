using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x0200004B RID: 75
	public static class Debugger : Object
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x0001B288 File Offset: 0x00019488
		// Note: this type is marked as 'beforefieldinit'.
		static Debugger()
		{
			Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "Debugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
			Debugger.NativeFieldInfoPtr_logPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "logPriority");
			Debugger.NativeFieldInfoPtr__LogPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "_LogPrefix");
			Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664176);
			Debugger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664177);
			Debugger.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664178);
			Debugger.NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664179);
			Debugger.NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664180);
			Debugger.NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664181);
			Debugger.NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664182);
			Debugger.NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664183);
			Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664184);
			Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664185);
			Debugger.NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664186);
			Debugger.NativeMethodInfoPtr_LogAddActiveTweenError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664187);
			Debugger.NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664188);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001B3E4 File Offset: 0x000195E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124179, XrefRangeEnd = 124189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001B41C File Offset: 0x0001961C
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 124199, RefRangeEnd = 124256, XrefRangeStart = 124189, XrefRangeEnd = 124199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001B454 File Offset: 0x00019654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124266, RefRangeEnd = 124268, XrefRangeStart = 124256, XrefRangeEnd = 124266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001B48C File Offset: 0x0001968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124268, XrefRangeEnd = 124277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogReport(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001B4C4 File Offset: 0x000196C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124277, XrefRangeEnd = 124280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogInvalidTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001B4FC File Offset: 0x000196FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124280, XrefRangeEnd = 124283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNestedTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001B534 File Offset: 0x00019734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124283, XrefRangeEnd = 124286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNullTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001B56C File Offset: 0x0001976C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124286, XrefRangeEnd = 124289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNonPathTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001B5A4 File Offset: 0x000197A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124289, XrefRangeEnd = 124293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogMissingMaterialProperty(string propertyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001B5DC File Offset: 0x000197DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124293, XrefRangeEnd = 124300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogMissingMaterialProperty(int propertyId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propertyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001B610 File Offset: 0x00019810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124304, RefRangeEnd = 124307, XrefRangeStart = 124300, XrefRangeEnd = 124304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogRemoveActiveTweenError(string errorInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001B648 File Offset: 0x00019848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124307, XrefRangeEnd = 124311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAddActiveTweenError(string errorInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogAddActiveTweenError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001B680 File Offset: 0x00019880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124311, XrefRangeEnd = 124313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLogPriority(LogBehaviour logBehaviour)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logBehaviour;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00003689 File Offset: 0x00001889
		public Debugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0001B6B4 File Offset: 0x000198B4
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003692 File Offset: 0x00001892
		public unsafe static int logPriority
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr_logPriority, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr_logPriority, (void*)(&value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001B6D0 File Offset: 0x000198D0
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x000036A0 File Offset: 0x000018A0
		public unsafe static string _LogPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr__LogPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr__LogPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_logPriority;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr__LogPrefix;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_Int32_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_LogAddActiveTweenError_Public_Static_Void_String_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0;
	}
}
