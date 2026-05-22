using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026F RID: 623
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x000E1144 File Offset: 0x000DF344
		// Note: this type is marked as 'beforefieldinit'.
		static EventWaitHandle()
		{
			Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "EventWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670234);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670235);
			EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670236);
			EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100670237);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000E11C4 File Offset: 0x000DF3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201017, XrefRangeEnd = 201018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000E121C File Offset: 0x000DF41C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 201040, RefRangeEnd = 201062, XrefRangeStart = 201018, XrefRangeEnd = 201040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000E1284 File Offset: 0x000DF484
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 201063, RefRangeEnd = 201071, XrefRangeStart = 201062, XrefRangeEnd = 201063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000E12C0 File Offset: 0x000DF4C0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 201072, RefRangeEnd = 201089, XrefRangeStart = 201071, XrefRangeEnd = 201072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x0000EF1E File Offset: 0x0000D11E
		public EventWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Boolean_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_0;
	}
}
