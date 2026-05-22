using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000115 RID: 277
	public sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x06001672 RID: 5746 RVA: 0x000729AC File Offset: 0x00070BAC
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleContentValidator()
		{
			Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ParticleContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr);
			ParticleContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "symbols");
			ParticleContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "positions");
			ParticleContentValidator.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "stack");
			ParticleContentValidator.NativeFieldInfoPtr_contentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "contentNode");
			ParticleContentValidator.NativeFieldInfoPtr_isPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "isPartial");
			ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "minMaxNodesCount");
			ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "enableUpaCheck");
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666678);
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666679);
			ParticleContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666680);
			ParticleContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666681);
			ParticleContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666682);
			ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666683);
			ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666684);
			ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666685);
			ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666686);
			ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666687);
			ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666688);
			ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666689);
			ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666690);
			ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666691);
			ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666692);
			ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666693);
			ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666694);
			ParticleContentValidator.NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666695);
			ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666696);
			ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666697);
			ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666698);
			ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666699);
			ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666700);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666701);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666702);
			ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100666703);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00072C70 File Offset: 0x00070E70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409547, RefRangeEnd = 409550, XrefRangeStart = 409544, XrefRangeEnd = 409547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00072CB8 File Offset: 0x00070EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409550, XrefRangeEnd = 409553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableUpaCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00072D10 File Offset: 0x00070F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409553, XrefRangeEnd = 409558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00072D54 File Offset: 0x00070F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409558, XrefRangeEnd = 409563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00072DC4 File Offset: 0x00070FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409563, XrefRangeEnd = 409568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00072E14 File Offset: 0x00071014
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409590, RefRangeEnd = 409594, XrefRangeStart = 409568, XrefRangeEnd = 409590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00072E48 File Offset: 0x00071048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409594, XrefRangeEnd = 409595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00072E7C File Offset: 0x0007107C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 409601, RefRangeEnd = 409607, XrefRangeStart = 409595, XrefRangeEnd = 409601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00072EB0 File Offset: 0x000710B0
		[CallerCount(0)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00072F00 File Offset: 0x00071100
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 409614, RefRangeEnd = 409619, XrefRangeStart = 409607, XrefRangeEnd = 409614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00072F54 File Offset: 0x00071154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409625, RefRangeEnd = 409627, XrefRangeStart = 409619, XrefRangeEnd = 409625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList namespaceList, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00072FA8 File Offset: 0x000711A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409630, RefRangeEnd = 409632, XrefRangeStart = 409627, XrefRangeEnd = 409630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeafNode(SyntaxTreeNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00072FEC File Offset: 0x000711EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409640, RefRangeEnd = 409644, XrefRangeStart = 409632, XrefRangeEnd = 409640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00073020 File Offset: 0x00071220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409652, RefRangeEnd = 409655, XrefRangeStart = 409644, XrefRangeEnd = 409652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00073054 File Offset: 0x00071254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409659, RefRangeEnd = 409661, XrefRangeStart = 409655, XrefRangeEnd = 409659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00073088 File Offset: 0x00071288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409665, RefRangeEnd = 409667, XrefRangeStart = 409661, XrefRangeEnd = 409665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000730BC File Offset: 0x000712BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409671, RefRangeEnd = 409674, XrefRangeStart = 409667, XrefRangeEnd = 409671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQMark()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000730F0 File Offset: 0x000712F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409682, RefRangeEnd = 409683, XrefRangeStart = 409674, XrefRangeEnd = 409682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeafRange(Decimal min, Decimal max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0007313C File Offset: 0x0007133C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 409687, RefRangeEnd = 409699, XrefRangeStart = 409683, XrefRangeEnd = 409687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Closure(InteriorNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00073180 File Offset: 0x00071380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409738, RefRangeEnd = 409742, XrefRangeStart = 409699, XrefRangeEnd = 409738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator Finish(bool useDFA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useDFA;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000731CC File Offset: 0x000713CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409742, XrefRangeEnd = 409775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<BitSet> CalculateTotalFollowposForRangeNodes(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, out BitSet posWithRangeTerminals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			posWithRangeTerminals = ((intPtr4 == 0) ? null : new BitSet(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr5) : null;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00073254 File Offset: 0x00071454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409775, XrefRangeEnd = 409784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00073298 File Offset: 0x00071498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409784, XrefRangeEnd = 409799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, Il2CppReferenceArray<BitSet> minmaxFollowPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(posWithRangeTerminals);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minmaxFollowPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0007330C File Offset: 0x0007150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409799, XrefRangeEnd = 409802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00073360 File Offset: 0x00071560
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409814, RefRangeEnd = 409818, XrefRangeStart = 409802, XrefRangeEnd = 409814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000733A4 File Offset: 0x000715A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409862, RefRangeEnd = 409863, XrefRangeStart = 409818, XrefRangeEnd = 409862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> BuildTransitionTable(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, int endMarkerPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr3) : null;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00009F5F File Offset: 0x0000815F
		public ParticleContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00073414 File Offset: 0x00071614
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x00009F68 File Offset: 0x00008168
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00073444 File Offset: 0x00071644
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00009F87 File Offset: 0x00008187
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x00073474 File Offset: 0x00071674
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x00009FA6 File Offset: 0x000081A6
		public unsafe Stack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000734A4 File Offset: 0x000716A4
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00009FC5 File Offset: 0x000081C5
		public unsafe SyntaxTreeNode contentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000734D4 File Offset: 0x000716D4
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x00009FE4 File Offset: 0x000081E4
		public unsafe bool isPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x000734FC File Offset: 0x000716FC
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00009FFF File Offset: 0x000081FF
		public unsafe int minMaxNodesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00073524 File Offset: 0x00071724
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0000A01A File Offset: 0x0000821A
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr_contentNode;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeFieldInfoPtr_isPartial;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeFieldInfoPtr_minMaxNodesCount;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_OpenGroup_Public_Void_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_CloseGroup_Public_Void_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_AddChoice_Public_Void_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_AddSequence_Public_Void_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_AddStar_Public_Void_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_AddPlus_Public_Void_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_AddQMark_Public_Void_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0;
	}
}
