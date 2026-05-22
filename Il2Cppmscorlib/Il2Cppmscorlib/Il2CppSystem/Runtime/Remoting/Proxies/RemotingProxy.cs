using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AD RID: 941
	public class RemotingProxy : RealProxy
	{
		// Token: 0x06003E14 RID: 15892 RVA: 0x00125808 File Offset: 0x00123A08
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingProxy()
		{
			Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RemotingProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr);
			RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetTypeMethod");
			RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetHashCodeMethod");
			RemotingProxy.NativeFieldInfoPtr__sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_sink");
			RemotingProxy.NativeFieldInfoPtr__hasEnvoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_hasEnvoySink");
			RemotingProxy.NativeFieldInfoPtr__ctorCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_ctorCall");
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672495);
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672496);
			RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672497);
			RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672498);
			RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672499);
			RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672500);
			RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672501);
			RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100672502);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0012593C File Offset: 0x00123B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221830, XrefRangeEnd = 221832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0012599C File Offset: 0x00123B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221835, RefRangeEnd = 221837, XrefRangeStart = 221832, XrefRangeEnd = 221835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00125A0C File Offset: 0x00123C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221837, XrefRangeEnd = 221866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage Invoke(IMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00125A68 File Offset: 0x00123C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221880, RefRangeEnd = 221881, XrefRangeStart = 221866, XrefRangeEnd = 221880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachIdentity(Identity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00125AAC File Offset: 0x00123CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221881, XrefRangeEnd = 221891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage ActivateRemoteObject(IMethodMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00125AFC File Offset: 0x00123CFC
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221891, XrefRangeEnd = 221898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00125B34 File Offset: 0x00123D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221898, XrefRangeEnd = 221910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00125B94 File Offset: 0x00123D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221910, XrefRangeEnd = 221917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00017284 File Offset: 0x00015484
		public RemotingProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x00125BD0 File Offset: 0x00123DD0
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x0001728D File Offset: 0x0001548D
		public unsafe static MethodInfo _cache_GetTypeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00125BF8 File Offset: 0x00123DF8
		// (set) Token: 0x06003E21 RID: 15905 RVA: 0x0001729F File Offset: 0x0001549F
		public unsafe static MethodInfo _cache_GetHashCodeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00125C20 File Offset: 0x00123E20
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x000172B1 File Offset: 0x000154B1
		public unsafe IMessageSink _sink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x00125C50 File Offset: 0x00123E50
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x000172D0 File Offset: 0x000154D0
		public unsafe bool _hasEnvoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink)) = value;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00125C78 File Offset: 0x00123E78
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x000172EB File Offset: 0x000154EB
		public unsafe ConstructionCall _ctorCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetTypeMethod;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetHashCodeMethod;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeFieldInfoPtr__sink;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeFieldInfoPtr__hasEnvoySink;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeFieldInfoPtr__ctorCall;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
