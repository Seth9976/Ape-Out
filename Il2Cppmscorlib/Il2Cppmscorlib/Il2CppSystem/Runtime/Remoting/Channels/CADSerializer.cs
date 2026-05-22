using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C7 RID: 967
	public class CADSerializer : Object
	{
		// Token: 0x06003F32 RID: 16178 RVA: 0x00129770 File Offset: 0x00127970
		// Note: this type is marked as 'beforefieldinit'.
		static CADSerializer()
		{
			Il2CppClassPointerStore<CADSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CADSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr);
			CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672644);
			CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672645);
			CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672646);
			CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672647);
			CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672648);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00129804 File Offset: 0x00127A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223313, XrefRangeEnd = 223318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0012985C File Offset: 0x00127A5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223330, RefRangeEnd = 223333, XrefRangeStart = 223318, XrefRangeEnd = 223330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001298A0 File Offset: 0x00127AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223355, RefRangeEnd = 223357, XrefRangeStart = 223333, XrefRangeEnd = 223355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObjectSafe(Il2CppStructArray<byte> mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001298E4 File Offset: 0x00127AE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223369, RefRangeEnd = 223374, XrefRangeStart = 223357, XrefRangeEnd = 223369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00129928 File Offset: 0x00127B28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223379, RefRangeEnd = 223384, XrefRangeStart = 223374, XrefRangeEnd = 223379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(MemoryStream mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0001797C File Offset: 0x00015B7C
		public CADSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0;

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0;
	}
}
