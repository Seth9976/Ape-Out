using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C5 RID: 965
	[Serializable]
	public class CrossAppDomainChannel : Object
	{
		// Token: 0x06003F17 RID: 16151 RVA: 0x00129078 File Offset: 0x00127278
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainChannel()
		{
			Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr);
			CrossAppDomainChannel.NativeFieldInfoPtr_s_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, "s_lock");
			CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672627);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672628);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672629);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672630);
			CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672631);
			CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672632);
			CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100672633);
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00129148 File Offset: 0x00127348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223147, RefRangeEnd = 223148, XrefRangeStart = 223130, XrefRangeEnd = 223147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCrossAppDomainChannel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003F19 RID: 16153 RVA: 0x00129170 File Offset: 0x00127370
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223148, XrefRangeEnd = 223150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x001291B4 File Offset: 0x001273B4
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x001291FC File Offset: 0x001273FC
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223150, XrefRangeEnd = 223156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00129248 File Offset: 0x00127448
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x00129298 File Offset: 0x00127498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223156, XrefRangeEnd = 223169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object data, out string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			uri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00129320 File Offset: 0x00127520
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00017919 File Offset: 0x00015B19
		public CrossAppDomainChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0012935C File Offset: 0x0012755C
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x00017922 File Offset: 0x00015B22
		public unsafe static Object s_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeFieldInfoPtr_s_lock;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0;

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
