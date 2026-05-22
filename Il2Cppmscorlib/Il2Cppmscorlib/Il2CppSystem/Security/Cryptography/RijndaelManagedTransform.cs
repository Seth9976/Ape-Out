using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FB RID: 763
	public sealed class RijndaelManagedTransform : Object
	{
		// Token: 0x06003299 RID: 12953 RVA: 0x000FCCE8 File Offset: 0x000FAEE8
		// Note: this type is marked as 'beforefieldinit'.
		static RijndaelManagedTransform()
		{
			Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RijndaelManagedTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr);
			RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_cipherMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_paddingValue");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_transformMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBits");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBytes");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_inputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_outputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nr");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nb");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nk");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_IV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_IV");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_lastBlockBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_depadBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_shiftRegister");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Sbox");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Rcon");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_T");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_TF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_TF");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iT");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iTF");
			RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671275);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671276);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671277);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671278);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671279);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671280);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671281);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671282);
			RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671283);
			RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671284);
			RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671285);
			RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671286);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671287);
			RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671288);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671289);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671290);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671291);
			RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671292);
			RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671293);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000FD074 File Offset: 0x000FB274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210506, RefRangeEnd = 210509, XrefRangeStart = 210466, XrefRangeEnd = 210506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RijndaelManagedTransform(Il2CppStructArray<byte> rgbKey, CipherMode mode, Il2CppStructArray<byte> rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref feedbackSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PaddingValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000FD118 File Offset: 0x000FB318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210509, XrefRangeEnd = 210521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000FD14C File Offset: 0x000FB34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210521, XrefRangeEnd = 210533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000FD18C File Offset: 0x000FB38C
		public unsafe int InputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
		public unsafe int OutputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x000FD204 File Offset: 0x000FB404
		public unsafe bool CanTransformMultipleBlocks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000FD240 File Offset: 0x000FB440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210533, XrefRangeEnd = 210541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000FD2CC File Offset: 0x000FB4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210541, XrefRangeEnd = 210556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000FD338 File Offset: 0x000FB538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210565, RefRangeEnd = 210566, XrefRangeStart = 210556, XrefRangeEnd = 210565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000FD36C File Offset: 0x000FB56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210566, XrefRangeEnd = 210631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EncryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000FD42C File Offset: 0x000FB62C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210688, RefRangeEnd = 210691, XrefRangeStart = 210631, XrefRangeEnd = 210688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DecryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000FD4EC File Offset: 0x000FB6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210691, RefRangeEnd = 210693, XrefRangeStart = 210691, XrefRangeEnd = 210691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = encryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = encryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = T;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = TF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000FD570 File Offset: 0x000FB770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210693, RefRangeEnd = 210694, XrefRangeStart = 210693, XrefRangeEnd = 210693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = decryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = decryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iT;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iTF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000FD5F4 File Offset: 0x000FB7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210712, RefRangeEnd = 210713, XrefRangeStart = 210694, XrefRangeEnd = 210712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyExpansion(Il2CppStructArray<byte> rgbKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000FD638 File Offset: 0x000FB838
		[CallerCount(0)]
		public unsafe static int rot1(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000FD678 File Offset: 0x000FB878
		[CallerCount(0)]
		public unsafe static int rot2(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000FD6B8 File Offset: 0x000FB8B8
		[CallerCount(0)]
		public unsafe static int rot3(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000FD6F8 File Offset: 0x000FB8F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210717, RefRangeEnd = 210719, XrefRangeStart = 210713, XrefRangeEnd = 210717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SubWord(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000FD738 File Offset: 0x000FB938
		[CallerCount(0)]
		public unsafe static int MulX(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00011B4A File Offset: 0x0000FD4A
		public RijndaelManagedTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000FD778 File Offset: 0x000FB978
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x00011B53 File Offset: 0x0000FD53
		public unsafe CipherMode m_cipherMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode)) = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000FD7A0 File Offset: 0x000FB9A0
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00011B6E File Offset: 0x0000FD6E
		public unsafe PaddingMode m_paddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue)) = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000FD7C8 File Offset: 0x000FB9C8
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00011B89 File Offset: 0x0000FD89
		public unsafe RijndaelManagedTransformMode m_transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode)) = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000FD7F0 File Offset: 0x000FB9F0
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		public unsafe int m_blockSizeBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits)) = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000FD818 File Offset: 0x000FBA18
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00011BBF File Offset: 0x0000FDBF
		public unsafe int m_blockSizeBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes)) = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000FD840 File Offset: 0x000FBA40
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00011BDA File Offset: 0x0000FDDA
		public unsafe int m_inputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize)) = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000FD868 File Offset: 0x000FBA68
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x00011BF5 File Offset: 0x0000FDF5
		public unsafe int m_outputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000FD890 File Offset: 0x000FBA90
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00011C10 File Offset: 0x0000FE10
		public unsafe Il2CppStructArray<int> m_encryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x000FD8C0 File Offset: 0x000FBAC0
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00011C2F File Offset: 0x0000FE2F
		public unsafe Il2CppStructArray<int> m_decryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00011C4E File Offset: 0x0000FE4E
		public unsafe int m_Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr)) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000FD918 File Offset: 0x000FBB18
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x00011C69 File Offset: 0x0000FE69
		public unsafe int m_Nb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb)) = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000FD940 File Offset: 0x000FBB40
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00011C84 File Offset: 0x0000FE84
		public unsafe int m_Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk)) = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000FD968 File Offset: 0x000FBB68
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00011C9F File Offset: 0x0000FE9F
		public unsafe Il2CppStructArray<int> m_encryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000FD998 File Offset: 0x000FBB98
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x00011CBE File Offset: 0x0000FEBE
		public unsafe Il2CppStructArray<int> m_decryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x000FD9C8 File Offset: 0x000FBBC8
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00011CDD File Offset: 0x0000FEDD
		public unsafe Il2CppStructArray<int> m_IV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000FD9F8 File Offset: 0x000FBBF8
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public unsafe Il2CppStructArray<int> m_lastBlockBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x000FDA28 File Offset: 0x000FBC28
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00011D1B File Offset: 0x0000FF1B
		public unsafe Il2CppStructArray<byte> m_depadBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x000FDA58 File Offset: 0x000FBC58
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x00011D3A File Offset: 0x0000FF3A
		public unsafe Il2CppStructArray<byte> m_shiftRegister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x000FDA88 File Offset: 0x000FBC88
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x00011D59 File Offset: 0x0000FF59
		public unsafe static Il2CppStructArray<byte> s_Sbox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x000FDAB0 File Offset: 0x000FBCB0
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x00011D6B File Offset: 0x0000FF6B
		public unsafe static Il2CppStructArray<int> s_Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x000FDAD8 File Offset: 0x000FBCD8
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x00011D7D File Offset: 0x0000FF7D
		public unsafe static Il2CppStructArray<int> s_T
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x000FDB00 File Offset: 0x000FBD00
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00011D8F File Offset: 0x0000FF8F
		public unsafe static Il2CppStructArray<int> s_TF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x000FDB28 File Offset: 0x000FBD28
		// (set) Token: 0x060032DB RID: 13019 RVA: 0x00011DA1 File Offset: 0x0000FFA1
		public unsafe static Il2CppStructArray<int> s_iT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x000FDB50 File Offset: 0x000FBD50
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00011DB3 File Offset: 0x0000FFB3
		public unsafe static Il2CppStructArray<int> s_iTF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeFieldInfoPtr_m_cipherMode;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeFieldInfoPtr_m_paddingValue;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeFieldInfoPtr_m_transformMode;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBits;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBytes;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeFieldInfoPtr_m_inputBlockSize;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeFieldInfoPtr_m_outputBlockSize;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptKeyExpansion;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptKeyExpansion;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeFieldInfoPtr_m_Nr;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeFieldInfoPtr_m_Nb;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeFieldInfoPtr_m_Nk;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptindex;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptindex;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeFieldInfoPtr_m_IV;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeFieldInfoPtr_m_lastBlockBuffer;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeFieldInfoPtr_m_depadBuffer;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeFieldInfoPtr_m_shiftRegister;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeFieldInfoPtr_s_Sbox;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeFieldInfoPtr_s_Rcon;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeFieldInfoPtr_s_T;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeFieldInfoPtr_s_TF;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeFieldInfoPtr_s_iT;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeFieldInfoPtr_s_iTF;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0;
	}
}
