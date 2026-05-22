using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Metadata;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000394 RID: 916
	public class InternalRemotingServices : Object
	{
		// Token: 0x06003C69 RID: 15465 RVA: 0x0011F110 File Offset: 0x0011D310
		// Note: this type is marked as 'beforefieldinit'.
		static InternalRemotingServices()
		{
			Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "InternalRemotingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr);
			InternalRemotingServices.NativeFieldInfoPtr__soapAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, "_soapAttributes");
			InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, 100672281);
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x0011F168 File Offset: 0x0011D368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219134, RefRangeEnd = 219137, XrefRangeStart = 219082, XrefRangeEnd = 219134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SoapAttribute GetCachedSoapAttribute(Object reflectionObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SoapAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x000168AC File Offset: 0x00014AAC
		public InternalRemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x0011F1AC File Offset: 0x0011D3AC
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x000168B5 File Offset: 0x00014AB5
		public unsafe static Hashtable _soapAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeFieldInfoPtr__soapAttributes;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0;
	}
}
