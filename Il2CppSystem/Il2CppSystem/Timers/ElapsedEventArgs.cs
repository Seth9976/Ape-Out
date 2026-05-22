using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Timers
{
	// Token: 0x0200004A RID: 74
	public class ElapsedEventArgs : EventArgs
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x0002118C File Offset: 0x0001F38C
		// Note: this type is marked as 'beforefieldinit'.
		static ElapsedEventArgs()
		{
			Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Timers", "ElapsedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr);
			ElapsedEventArgs.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr, "time");
			ElapsedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr, 100664012);
			ElapsedEventArgs.NativeMethodInfoPtr_get_SignalTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr, 100664013);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000211F8 File Offset: 0x0001F3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369393, XrefRangeEnd = 369396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElapsedEventArgs(DateTime time)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElapsedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElapsedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00021240 File Offset: 0x0001F440
		public unsafe DateTime SignalTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElapsedEventArgs.NativeMethodInfoPtr_get_SignalTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003799 File Offset: 0x00001999
		public ElapsedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0002127C File Offset: 0x0001F47C
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x000037A2 File Offset: 0x000019A2
		public unsafe DateTime time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElapsedEventArgs.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElapsedEventArgs.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DateTime_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_SignalTime_Public_get_DateTime_0;
	}
}
