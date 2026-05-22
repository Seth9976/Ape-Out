using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D1 RID: 977
	public class ActivationServices : Object
	{
		// Token: 0x06003F61 RID: 16225 RVA: 0x00129FD0 File Offset: 0x001281D0
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationServices()
		{
			Il2CppClassPointerStore<ActivationServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ActivationServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr);
			ActivationServices.NativeFieldInfoPtr__constructionActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, "_constructionActivator");
			ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672661);
			ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672662);
			ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672663);
			ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672664);
			ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672665);
			ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672666);
			ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672667);
			ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100672668);
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x0012A0B4 File Offset: 0x001282B4
		public unsafe static IActivator ConstructionActivator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223403, RefRangeEnd = 223404, XrefRangeStart = 223396, XrefRangeEnd = 223403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0012A0E8 File Offset: 0x001282E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223428, RefRangeEnd = 223430, XrefRangeStart = 223404, XrefRangeEnd = 223428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0012A140 File Offset: 0x00128340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223440, RefRangeEnd = 223442, XrefRangeStart = 223430, XrefRangeEnd = 223440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x0012A184 File Offset: 0x00128384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223518, RefRangeEnd = 223519, XrefRangeStart = 223442, XrefRangeEnd = 223518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr3) : null;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0012A1EC File Offset: 0x001283EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223540, RefRangeEnd = 223541, XrefRangeStart = 223519, XrefRangeEnd = 223540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0012A230 File Offset: 0x00128430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223541, XrefRangeEnd = 223549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProxyForType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0012A274 File Offset: 0x00128474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213502, RefRangeEnd = 213503, XrefRangeStart = 213502, XrefRangeEnd = 213503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object AllocateUninitializedClassInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0012A2B8 File Offset: 0x001284B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223549, XrefRangeEnd = 223550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableProxyActivation(Type type, bool enable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00017B48 File Offset: 0x00015D48
		public ActivationServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x0012A2FC File Offset: 0x001284FC
		// (set) Token: 0x06003F6C RID: 16236 RVA: 0x00017B51 File Offset: 0x00015D51
		public unsafe static IActivator _constructionActivator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeFieldInfoPtr__constructionActivator;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0;
	}
}
