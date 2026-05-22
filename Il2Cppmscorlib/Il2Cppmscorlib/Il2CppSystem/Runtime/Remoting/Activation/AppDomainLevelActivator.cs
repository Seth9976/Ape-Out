using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D2 RID: 978
	public class AppDomainLevelActivator : Object
	{
		// Token: 0x06003F6D RID: 16237 RVA: 0x0012A324 File Offset: 0x00128524
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainLevelActivator()
		{
			Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "AppDomainLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr);
			AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_activationUrl");
			AppDomainLevelActivator.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_next");
			AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672669);
			AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672670);
			AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672671);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0012A3B8 File Offset: 0x001285B8
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainLevelActivator(string activationUrl, IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x0012A418 File Offset: 0x00128618
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0012A458 File Offset: 0x00128658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223550, XrefRangeEnd = 223592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00017B63 File Offset: 0x00015D63
		public AppDomainLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x0012A4A8 File Offset: 0x001286A8
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x00017B6C File Offset: 0x00015D6C
		public unsafe string _activationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x0012A4D0 File Offset: 0x001286D0
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x00017B8B File Offset: 0x00015D8B
		public unsafe IActivator _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeFieldInfoPtr__activationUrl;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
