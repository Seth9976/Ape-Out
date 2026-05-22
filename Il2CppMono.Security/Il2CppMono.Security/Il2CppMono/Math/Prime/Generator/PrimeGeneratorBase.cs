using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x02000035 RID: 53
	public class PrimeGeneratorBase : Object
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000DF24 File Offset: 0x0000C124
		// Note: this type is marked as 'beforefieldinit'.
		static PrimeGeneratorBase()
		{
			Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime.Generator", "PrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663701);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663702);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663703);
			PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663704);
			PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663705);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public unsafe virtual ConfidenceFactor Confidence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000E000 File Offset: 0x0000C200
		public unsafe virtual PrimalityTest PrimalityTest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131049, XrefRangeEnd = 131054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrimalityTest>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000E04C File Offset: 0x0000C24C
		public unsafe virtual int TrialDivisionBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E094 File Offset: 0x0000C294
		[CallerCount(0)]
		public unsafe virtual BigInteger GenerateNewPrime(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000032A8 File Offset: 0x000014A8
		public PrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
