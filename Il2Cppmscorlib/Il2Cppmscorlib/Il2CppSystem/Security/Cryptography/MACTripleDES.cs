using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F2 RID: 754
	public class MACTripleDES : KeyedHashAlgorithm
	{
		// Token: 0x0600323D RID: 12861 RVA: 0x000FB7FC File Offset: 0x000F99FC
		// Note: this type is marked as 'beforefieldinit'.
		static MACTripleDES()
		{
			Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MACTripleDES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr);
			MACTripleDES.NativeFieldInfoPtr_m_encryptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_encryptor");
			MACTripleDES.NativeFieldInfoPtr__cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_cs");
			MACTripleDES.NativeFieldInfoPtr__ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_ts");
			MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_bytesPerBlock");
			MACTripleDES.NativeFieldInfoPtr_des = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "des");
			MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671228);
			MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671229);
			MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671230);
			MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671231);
			MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671232);
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000FB8F4 File Offset: 0x000F9AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210227, XrefRangeEnd = 210240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MACTripleDES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000FB930 File Offset: 0x000F9B30
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000FB96C File Offset: 0x000F9B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210240, XrefRangeEnd = 210249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgbData, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000FB9D8 File Offset: 0x000F9BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210249, XrefRangeEnd = 210262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000FBA24 File Offset: 0x000F9C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210262, XrefRangeEnd = 210269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0001196B File Offset: 0x0000FB6B
		public MACTripleDES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000FBA70 File Offset: 0x000F9C70
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x00011974 File Offset: 0x0000FB74
		public unsafe ICryptoTransform m_encryptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x00011993 File Offset: 0x0000FB93
		public unsafe CryptoStream _cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000FBAD0 File Offset: 0x000F9CD0
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x000119B2 File Offset: 0x0000FBB2
		public unsafe TailStream _ts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TailStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x000FBB00 File Offset: 0x000F9D00
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x000119D1 File Offset: 0x0000FBD1
		public unsafe int m_bytesPerBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock)) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000FBB28 File Offset: 0x000F9D28
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x000119EC File Offset: 0x0000FBEC
		public unsafe TripleDES des
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TripleDES>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptor;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeFieldInfoPtr__cs;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeFieldInfoPtr__ts;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeFieldInfoPtr_m_bytesPerBlock;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeFieldInfoPtr_des;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
