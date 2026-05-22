using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017B RID: 379
	public sealed class SchemaNames : Object
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x0008E2A0 File Offset: 0x0008C4A0
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNames()
		{
			Il2CppClassPointerStore<SchemaNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr);
			SchemaNames.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "nameTable");
			SchemaNames.NativeFieldInfoPtr_NsDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataType");
			SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataTypeAlias");
			SchemaNames.NativeFieldInfoPtr_NsDataTypeOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataTypeOld");
			SchemaNames.NativeFieldInfoPtr_NsXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXml");
			SchemaNames.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXmlNs");
			SchemaNames.NativeFieldInfoPtr_NsXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXdr");
			SchemaNames.NativeFieldInfoPtr_NsXdrAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXdrAlias");
			SchemaNames.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXs");
			SchemaNames.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXsi");
			SchemaNames.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiType");
			SchemaNames.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiNil");
			SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsdSchema");
			SchemaNames.NativeFieldInfoPtr_XdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XdrSchema");
			SchemaNames.NativeFieldInfoPtr_QnPCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnPCData");
			SchemaNames.NativeFieldInfoPtr_QnXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXml");
			SchemaNames.NativeFieldInfoPtr_QnXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXmlNs");
			SchemaNames.NativeFieldInfoPtr_QnDtDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtDt");
			SchemaNames.NativeFieldInfoPtr_QnXmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXmlLang");
			SchemaNames.NativeFieldInfoPtr_QnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnName");
			SchemaNames.NativeFieldInfoPtr_QnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnType");
			SchemaNames.NativeFieldInfoPtr_QnMaxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMaxOccurs");
			SchemaNames.NativeFieldInfoPtr_QnMinOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMinOccurs");
			SchemaNames.NativeFieldInfoPtr_QnInfinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnInfinite");
			SchemaNames.NativeFieldInfoPtr_QnModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnModel");
			SchemaNames.NativeFieldInfoPtr_QnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOpen");
			SchemaNames.NativeFieldInfoPtr_QnClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnClosed");
			SchemaNames.NativeFieldInfoPtr_QnContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnContent");
			SchemaNames.NativeFieldInfoPtr_QnMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMixed");
			SchemaNames.NativeFieldInfoPtr_QnEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEmpty");
			SchemaNames.NativeFieldInfoPtr_QnEltOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEltOnly");
			SchemaNames.NativeFieldInfoPtr_QnTextOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnTextOnly");
			SchemaNames.NativeFieldInfoPtr_QnOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOrder");
			SchemaNames.NativeFieldInfoPtr_QnSeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSeq");
			SchemaNames.NativeFieldInfoPtr_QnOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOne");
			SchemaNames.NativeFieldInfoPtr_QnMany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMany");
			SchemaNames.NativeFieldInfoPtr_QnRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRequired");
			SchemaNames.NativeFieldInfoPtr_QnYes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnYes");
			SchemaNames.NativeFieldInfoPtr_QnNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNo");
			SchemaNames.NativeFieldInfoPtr_QnString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnString");
			SchemaNames.NativeFieldInfoPtr_QnID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnID");
			SchemaNames.NativeFieldInfoPtr_QnIDRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnIDRef");
			SchemaNames.NativeFieldInfoPtr_QnIDRefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnIDRefs");
			SchemaNames.NativeFieldInfoPtr_QnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEntity");
			SchemaNames.NativeFieldInfoPtr_QnEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEntities");
			SchemaNames.NativeFieldInfoPtr_QnNmToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNmToken");
			SchemaNames.NativeFieldInfoPtr_QnNmTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNmTokens");
			SchemaNames.NativeFieldInfoPtr_QnEnumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEnumeration");
			SchemaNames.NativeFieldInfoPtr_QnDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDefault");
			SchemaNames.NativeFieldInfoPtr_QnXdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrSchema");
			SchemaNames.NativeFieldInfoPtr_QnXdrElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrElementType");
			SchemaNames.NativeFieldInfoPtr_QnXdrElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrElement");
			SchemaNames.NativeFieldInfoPtr_QnXdrGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrGroup");
			SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAttributeType");
			SchemaNames.NativeFieldInfoPtr_QnXdrAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXdrDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrDataType");
			SchemaNames.NativeFieldInfoPtr_QnXdrDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrDescription");
			SchemaNames.NativeFieldInfoPtr_QnXdrExtends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrExtends");
			SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAliasSchema");
			SchemaNames.NativeFieldInfoPtr_QnDtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtType");
			SchemaNames.NativeFieldInfoPtr_QnDtValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtValues");
			SchemaNames.NativeFieldInfoPtr_QnDtMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMaxLength");
			SchemaNames.NativeFieldInfoPtr_QnDtMinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMinLength");
			SchemaNames.NativeFieldInfoPtr_QnDtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMax");
			SchemaNames.NativeFieldInfoPtr_QnDtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMin");
			SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMinExclusive");
			SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMaxExclusive");
			SchemaNames.NativeFieldInfoPtr_QnTargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnTargetNamespace");
			SchemaNames.NativeFieldInfoPtr_QnVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnVersion");
			SchemaNames.NativeFieldInfoPtr_QnFinalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFinalDefault");
			SchemaNames.NativeFieldInfoPtr_QnBlockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBlockDefault");
			SchemaNames.NativeFieldInfoPtr_QnFixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFixed");
			SchemaNames.NativeFieldInfoPtr_QnAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnAbstract");
			SchemaNames.NativeFieldInfoPtr_QnBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBlock");
			SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSubstitutionGroup");
			SchemaNames.NativeFieldInfoPtr_QnFinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFinal");
			SchemaNames.NativeFieldInfoPtr_QnNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNillable");
			SchemaNames.NativeFieldInfoPtr_QnRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRef");
			SchemaNames.NativeFieldInfoPtr_QnBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBase");
			SchemaNames.NativeFieldInfoPtr_QnDerivedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDerivedBy");
			SchemaNames.NativeFieldInfoPtr_QnNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNamespace");
			SchemaNames.NativeFieldInfoPtr_QnProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnProcessContents");
			SchemaNames.NativeFieldInfoPtr_QnRefer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRefer");
			SchemaNames.NativeFieldInfoPtr_QnPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnPublic");
			SchemaNames.NativeFieldInfoPtr_QnSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSystem");
			SchemaNames.NativeFieldInfoPtr_QnSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_QnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnValue");
			SchemaNames.NativeFieldInfoPtr_QnUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnUse");
			SchemaNames.NativeFieldInfoPtr_QnForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnForm");
			SchemaNames.NativeFieldInfoPtr_QnElementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnElementFormDefault");
			SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnAttributeFormDefault");
			SchemaNames.NativeFieldInfoPtr_QnItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnItemType");
			SchemaNames.NativeFieldInfoPtr_QnMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMemberTypes");
			SchemaNames.NativeFieldInfoPtr_QnXPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXPath");
			SchemaNames.NativeFieldInfoPtr_QnXsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSchema");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnnotation");
			SchemaNames.NativeFieldInfoPtr_QnXsdInclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdInclude");
			SchemaNames.NativeFieldInfoPtr_QnXsdImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdImport");
			SchemaNames.NativeFieldInfoPtr_QnXsdElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdElement");
			SchemaNames.NativeFieldInfoPtr_QnXsdAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAttributeGroup");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnyAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXsdGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdGroup");
			SchemaNames.NativeFieldInfoPtr_QnXsdAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAll");
			SchemaNames.NativeFieldInfoPtr_QnXsdChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdChoice");
			SchemaNames.NativeFieldInfoPtr_QnXsdSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSequence");
			SchemaNames.NativeFieldInfoPtr_QnXsdAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAny");
			SchemaNames.NativeFieldInfoPtr_QnXsdNotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdNotation");
			SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSimpleType");
			SchemaNames.NativeFieldInfoPtr_QnXsdComplexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdComplexType");
			SchemaNames.NativeFieldInfoPtr_QnXsdUnique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdUnique");
			SchemaNames.NativeFieldInfoPtr_QnXsdKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdKey");
			SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdKeyRef");
			SchemaNames.NativeFieldInfoPtr_QnXsdSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSelector");
			SchemaNames.NativeFieldInfoPtr_QnXsdField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdField");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinExclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinInclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxInclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxExclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdTotalDigits");
			SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdFractionDigits");
			SchemaNames.NativeFieldInfoPtr_QnXsdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdEnumeration");
			SchemaNames.NativeFieldInfoPtr_QnXsdPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdPattern");
			SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdDocumentation");
			SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAppinfo");
			SchemaNames.NativeFieldInfoPtr_QnSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSource");
			SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdComplexContent");
			SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSimpleContent");
			SchemaNames.NativeFieldInfoPtr_QnXsdRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdRestriction");
			SchemaNames.NativeFieldInfoPtr_QnXsdExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdExtension");
			SchemaNames.NativeFieldInfoPtr_QnXsdUnion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdUnion");
			SchemaNames.NativeFieldInfoPtr_QnXsdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdList");
			SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdWhiteSpace");
			SchemaNames.NativeFieldInfoPtr_QnXsdRedefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdRedefine");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnyType");
			SchemaNames.NativeFieldInfoPtr_TokenToQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "TokenToQName");
			SchemaNames.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100667616);
			SchemaNames.NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100667617);
			SchemaNames.NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100667618);
			SchemaNames.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100667619);
			SchemaNames.NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100667620);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0008EE38 File Offset: 0x0008D038
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 421255, RefRangeEnd = 421263, XrefRangeStart = 420498, XrefRangeEnd = 421255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNames(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0008EE84 File Offset: 0x0008D084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 421760, RefRangeEnd = 421761, XrefRangeStart = 421263, XrefRangeEnd = 421760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTokenToQNameTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0008EEB8 File Offset: 0x0008D0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 421763, RefRangeEnd = 421765, XrefRangeStart = 421761, XrefRangeEnd = 421763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType SchemaTypeFromRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0008EF18 File Offset: 0x0008D118
		[CallerCount(0)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0008EF78 File Offset: 0x0008D178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 421765, RefRangeEnd = 421767, XrefRangeStart = 421765, XrefRangeEnd = 421765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXDRRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0000C38F File Offset: 0x0000A58F
		public SchemaNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0008EFD8 File Offset: 0x0008D1D8
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x0000C398 File Offset: 0x0000A598
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0008F008 File Offset: 0x0008D208
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0000C3B7 File Offset: 0x0000A5B7
		public unsafe string NsDataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x0008F030 File Offset: 0x0008D230
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0000C3D6 File Offset: 0x0000A5D6
		public unsafe string NsDataTypeAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0008F058 File Offset: 0x0008D258
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0000C3F5 File Offset: 0x0000A5F5
		public unsafe string NsDataTypeOld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeOld);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeOld), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0008F080 File Offset: 0x0008D280
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0000C414 File Offset: 0x0000A614
		public unsafe string NsXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0008F0A8 File Offset: 0x0008D2A8
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0000C433 File Offset: 0x0000A633
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0008F0D0 File Offset: 0x0008D2D0
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0000C452 File Offset: 0x0000A652
		public unsafe string NsXdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0008F0F8 File Offset: 0x0008D2F8
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0000C471 File Offset: 0x0000A671
		public unsafe string NsXdrAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdrAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdrAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0008F120 File Offset: 0x0008D320
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x0000C490 File Offset: 0x0000A690
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0008F148 File Offset: 0x0008D348
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0000C4AF File Offset: 0x0000A6AF
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0008F170 File Offset: 0x0008D370
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0000C4CE File Offset: 0x0000A6CE
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0008F198 File Offset: 0x0008D398
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0000C4ED File Offset: 0x0000A6ED
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0008F1C0 File Offset: 0x0008D3C0
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0000C50C File Offset: 0x0000A70C
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0008F1E8 File Offset: 0x0008D3E8
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0000C52B File Offset: 0x0000A72B
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0008F210 File Offset: 0x0008D410
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0000C54A File Offset: 0x0000A74A
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0008F238 File Offset: 0x0008D438
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000C569 File Offset: 0x0000A769
		public unsafe string XdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XdrSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XdrSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0008F260 File Offset: 0x0008D460
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000C588 File Offset: 0x0000A788
		public unsafe XmlQualifiedName QnPCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0008F290 File Offset: 0x0008D490
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000C5A7 File Offset: 0x0000A7A7
		public unsafe XmlQualifiedName QnXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXml);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXml), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0008F2C0 File Offset: 0x0008D4C0
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000C5C6 File Offset: 0x0000A7C6
		public unsafe XmlQualifiedName QnXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlNs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlNs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0008F2F0 File Offset: 0x0008D4F0
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
		public unsafe XmlQualifiedName QnDtDt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtDt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtDt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0008F320 File Offset: 0x0008D520
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0000C604 File Offset: 0x0000A804
		public unsafe XmlQualifiedName QnXmlLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0008F350 File Offset: 0x0008D550
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000C623 File Offset: 0x0000A823
		public unsafe XmlQualifiedName QnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0008F380 File Offset: 0x0008D580
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000C642 File Offset: 0x0000A842
		public unsafe XmlQualifiedName QnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0008F3B0 File Offset: 0x0008D5B0
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000C661 File Offset: 0x0000A861
		public unsafe XmlQualifiedName QnMaxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMaxOccurs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMaxOccurs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000C680 File Offset: 0x0000A880
		public unsafe XmlQualifiedName QnMinOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMinOccurs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMinOccurs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0008F410 File Offset: 0x0008D610
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000C69F File Offset: 0x0000A89F
		public unsafe XmlQualifiedName QnInfinite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnInfinite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnInfinite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0008F440 File Offset: 0x0008D640
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000C6BE File Offset: 0x0000A8BE
		public unsafe XmlQualifiedName QnModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0008F470 File Offset: 0x0008D670
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0000C6DD File Offset: 0x0000A8DD
		public unsafe XmlQualifiedName QnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		public unsafe XmlQualifiedName QnClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0008F4D0 File Offset: 0x0008D6D0
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0000C71B File Offset: 0x0000A91B
		public unsafe XmlQualifiedName QnContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0008F500 File Offset: 0x0008D700
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000C73A File Offset: 0x0000A93A
		public unsafe XmlQualifiedName QnMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0008F530 File Offset: 0x0008D730
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000C759 File Offset: 0x0000A959
		public unsafe XmlQualifiedName QnEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0008F560 File Offset: 0x0008D760
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000C778 File Offset: 0x0000A978
		public unsafe XmlQualifiedName QnEltOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEltOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEltOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0008F590 File Offset: 0x0008D790
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000C797 File Offset: 0x0000A997
		public unsafe XmlQualifiedName QnTextOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTextOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTextOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0000C7B6 File Offset: 0x0000A9B6
		public unsafe XmlQualifiedName QnOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000C7D5 File Offset: 0x0000A9D5
		public unsafe XmlQualifiedName QnSeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSeq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSeq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0008F620 File Offset: 0x0008D820
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public unsafe XmlQualifiedName QnOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0008F650 File Offset: 0x0008D850
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000C813 File Offset: 0x0000AA13
		public unsafe XmlQualifiedName QnMany
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMany);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMany), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0008F680 File Offset: 0x0008D880
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000C832 File Offset: 0x0000AA32
		public unsafe XmlQualifiedName QnRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRequired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRequired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0008F6B0 File Offset: 0x0008D8B0
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000C851 File Offset: 0x0000AA51
		public unsafe XmlQualifiedName QnYes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnYes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnYes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0008F6E0 File Offset: 0x0008D8E0
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000C870 File Offset: 0x0000AA70
		public unsafe XmlQualifiedName QnNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0008F710 File Offset: 0x0008D910
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000C88F File Offset: 0x0000AA8F
		public unsafe XmlQualifiedName QnString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0008F740 File Offset: 0x0008D940
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0000C8AE File Offset: 0x0000AAAE
		public unsafe XmlQualifiedName QnID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0008F770 File Offset: 0x0008D970
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0000C8CD File Offset: 0x0000AACD
		public unsafe XmlQualifiedName QnIDRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x0008F7A0 File Offset: 0x0008D9A0
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		public unsafe XmlQualifiedName QnIDRefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0000C90B File Offset: 0x0000AB0B
		public unsafe XmlQualifiedName QnEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0008F800 File Offset: 0x0008DA00
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000C92A File Offset: 0x0000AB2A
		public unsafe XmlQualifiedName QnEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0008F830 File Offset: 0x0008DA30
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000C949 File Offset: 0x0000AB49
		public unsafe XmlQualifiedName QnNmToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0008F860 File Offset: 0x0008DA60
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000C968 File Offset: 0x0000AB68
		public unsafe XmlQualifiedName QnNmTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0008F890 File Offset: 0x0008DA90
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000C987 File Offset: 0x0000AB87
		public unsafe XmlQualifiedName QnEnumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEnumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEnumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
		public unsafe XmlQualifiedName QnDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0008F8F0 File Offset: 0x0008DAF0
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0000C9C5 File Offset: 0x0000ABC5
		public unsafe XmlQualifiedName QnXdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0008F920 File Offset: 0x0008DB20
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		public unsafe XmlQualifiedName QnXdrElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0008F950 File Offset: 0x0008DB50
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0000CA03 File Offset: 0x0000AC03
		public unsafe XmlQualifiedName QnXdrElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0008F980 File Offset: 0x0008DB80
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0000CA22 File Offset: 0x0000AC22
		public unsafe XmlQualifiedName QnXdrGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0008F9B0 File Offset: 0x0008DBB0
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0000CA41 File Offset: 0x0000AC41
		public unsafe XmlQualifiedName QnXdrAttributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0008F9E0 File Offset: 0x0008DBE0
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0000CA60 File Offset: 0x0000AC60
		public unsafe XmlQualifiedName QnXdrAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0008FA10 File Offset: 0x0008DC10
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0000CA7F File Offset: 0x0000AC7F
		public unsafe XmlQualifiedName QnXdrDataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0008FA40 File Offset: 0x0008DC40
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x0000CA9E File Offset: 0x0000AC9E
		public unsafe XmlQualifiedName QnXdrDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0008FA70 File Offset: 0x0008DC70
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x0000CABD File Offset: 0x0000ACBD
		public unsafe XmlQualifiedName QnXdrExtends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrExtends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrExtends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0008FAA0 File Offset: 0x0008DCA0
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0000CADC File Offset: 0x0000ACDC
		public unsafe XmlQualifiedName QnXdrAliasSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0008FAD0 File Offset: 0x0008DCD0
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0000CAFB File Offset: 0x0000ACFB
		public unsafe XmlQualifiedName QnDtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0008FB00 File Offset: 0x0008DD00
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0000CB1A File Offset: 0x0000AD1A
		public unsafe XmlQualifiedName QnDtValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0008FB30 File Offset: 0x0008DD30
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0000CB39 File Offset: 0x0000AD39
		public unsafe XmlQualifiedName QnDtMaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0008FB60 File Offset: 0x0008DD60
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x0000CB58 File Offset: 0x0000AD58
		public unsafe XmlQualifiedName QnDtMinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x0008FB90 File Offset: 0x0008DD90
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0000CB77 File Offset: 0x0000AD77
		public unsafe XmlQualifiedName QnDtMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000CB96 File Offset: 0x0000AD96
		public unsafe XmlQualifiedName QnDtMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0008FBF0 File Offset: 0x0008DDF0
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0000CBB5 File Offset: 0x0000ADB5
		public unsafe XmlQualifiedName QnDtMinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0008FC20 File Offset: 0x0008DE20
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public unsafe XmlQualifiedName QnDtMaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0008FC50 File Offset: 0x0008DE50
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000CBF3 File Offset: 0x0000ADF3
		public unsafe XmlQualifiedName QnTargetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTargetNamespace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTargetNamespace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0008FC80 File Offset: 0x0008DE80
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000CC12 File Offset: 0x0000AE12
		public unsafe XmlQualifiedName QnVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0008FCB0 File Offset: 0x0008DEB0
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000CC31 File Offset: 0x0000AE31
		public unsafe XmlQualifiedName QnFinalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinalDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinalDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0008FCE0 File Offset: 0x0008DEE0
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public unsafe XmlQualifiedName QnBlockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlockDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlockDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008FD10 File Offset: 0x0008DF10
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000CC6F File Offset: 0x0000AE6F
		public unsafe XmlQualifiedName QnFixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0008FD40 File Offset: 0x0008DF40
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0000CC8E File Offset: 0x0000AE8E
		public unsafe XmlQualifiedName QnAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAbstract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAbstract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0008FD70 File Offset: 0x0008DF70
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000CCAD File Offset: 0x0000AEAD
		public unsafe XmlQualifiedName QnBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0008FDA0 File Offset: 0x0008DFA0
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000CCCC File Offset: 0x0000AECC
		public unsafe XmlQualifiedName QnSubstitutionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000CCEB File Offset: 0x0000AEEB
		public unsafe XmlQualifiedName QnFinal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0008FE00 File Offset: 0x0008E000
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0000CD0A File Offset: 0x0000AF0A
		public unsafe XmlQualifiedName QnNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0008FE30 File Offset: 0x0008E030
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000CD29 File Offset: 0x0000AF29
		public unsafe XmlQualifiedName QnRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0008FE60 File Offset: 0x0008E060
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0000CD48 File Offset: 0x0000AF48
		public unsafe XmlQualifiedName QnBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0008FE90 File Offset: 0x0008E090
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0000CD67 File Offset: 0x0000AF67
		public unsafe XmlQualifiedName QnDerivedBy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDerivedBy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDerivedBy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0008FEC0 File Offset: 0x0008E0C0
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x0000CD86 File Offset: 0x0000AF86
		public unsafe XmlQualifiedName QnNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNamespace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNamespace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0008FEF0 File Offset: 0x0008E0F0
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x0000CDA5 File Offset: 0x0000AFA5
		public unsafe XmlQualifiedName QnProcessContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnProcessContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnProcessContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x0008FF20 File Offset: 0x0008E120
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		public unsafe XmlQualifiedName QnRefer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRefer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRefer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0008FF50 File Offset: 0x0008E150
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0000CDE3 File Offset: 0x0000AFE3
		public unsafe XmlQualifiedName QnPublic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPublic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPublic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0008FF80 File Offset: 0x0008E180
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0000CE02 File Offset: 0x0000B002
		public unsafe XmlQualifiedName QnSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0008FFB0 File Offset: 0x0008E1B0
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0000CE21 File Offset: 0x0000B021
		public unsafe XmlQualifiedName QnSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSchemaLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSchemaLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0008FFE0 File Offset: 0x0008E1E0
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0000CE40 File Offset: 0x0000B040
		public unsafe XmlQualifiedName QnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00090010 File Offset: 0x0008E210
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000CE5F File Offset: 0x0000B05F
		public unsafe XmlQualifiedName QnUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00090040 File Offset: 0x0008E240
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000CE7E File Offset: 0x0000B07E
		public unsafe XmlQualifiedName QnForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnForm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnForm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00090070 File Offset: 0x0008E270
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000CE9D File Offset: 0x0000B09D
		public unsafe XmlQualifiedName QnElementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnElementFormDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnElementFormDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000900A0 File Offset: 0x0008E2A0
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public unsafe XmlQualifiedName QnAttributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000900D0 File Offset: 0x0008E2D0
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0000CEDB File Offset: 0x0000B0DB
		public unsafe XmlQualifiedName QnItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00090100 File Offset: 0x0008E300
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		public unsafe XmlQualifiedName QnMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00090130 File Offset: 0x0008E330
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x0000CF19 File Offset: 0x0000B119
		public unsafe XmlQualifiedName QnXPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00090160 File Offset: 0x0008E360
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0000CF38 File Offset: 0x0000B138
		public unsafe XmlQualifiedName QnXsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00090190 File Offset: 0x0008E390
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0000CF57 File Offset: 0x0000B157
		public unsafe XmlQualifiedName QnXsdAnnotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x000901C0 File Offset: 0x0008E3C0
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0000CF76 File Offset: 0x0000B176
		public unsafe XmlQualifiedName QnXsdInclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdInclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdInclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x000901F0 File Offset: 0x0008E3F0
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000CF95 File Offset: 0x0000B195
		public unsafe XmlQualifiedName QnXsdImport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdImport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdImport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00090220 File Offset: 0x0008E420
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		public unsafe XmlQualifiedName QnXsdElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00090250 File Offset: 0x0008E450
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0000CFD3 File Offset: 0x0000B1D3
		public unsafe XmlQualifiedName QnXsdAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00090280 File Offset: 0x0008E480
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0000CFF2 File Offset: 0x0000B1F2
		public unsafe XmlQualifiedName QnXsdAttributeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000902B0 File Offset: 0x0008E4B0
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x0000D011 File Offset: 0x0000B211
		public unsafe XmlQualifiedName QnXsdAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000902E0 File Offset: 0x0008E4E0
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x0000D030 File Offset: 0x0000B230
		public unsafe XmlQualifiedName QnXsdGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00090310 File Offset: 0x0008E510
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0000D04F File Offset: 0x0000B24F
		public unsafe XmlQualifiedName QnXsdAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00090340 File Offset: 0x0008E540
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0000D06E File Offset: 0x0000B26E
		public unsafe XmlQualifiedName QnXsdChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00090370 File Offset: 0x0008E570
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0000D08D File Offset: 0x0000B28D
		public unsafe XmlQualifiedName QnXsdSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000903A0 File Offset: 0x0008E5A0
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		public unsafe XmlQualifiedName QnXsdAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAny);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000903D0 File Offset: 0x0008E5D0
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x0000D0CB File Offset: 0x0000B2CB
		public unsafe XmlQualifiedName QnXsdNotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdNotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdNotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00090400 File Offset: 0x0008E600
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x0000D0EA File Offset: 0x0000B2EA
		public unsafe XmlQualifiedName QnXsdSimpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00090430 File Offset: 0x0008E630
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x0000D109 File Offset: 0x0000B309
		public unsafe XmlQualifiedName QnXsdComplexType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00090460 File Offset: 0x0008E660
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x0000D128 File Offset: 0x0000B328
		public unsafe XmlQualifiedName QnXsdUnique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnique);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnique), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00090490 File Offset: 0x0008E690
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x0000D147 File Offset: 0x0000B347
		public unsafe XmlQualifiedName QnXsdKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000904C0 File Offset: 0x0008E6C0
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x0000D166 File Offset: 0x0000B366
		public unsafe XmlQualifiedName QnXsdKeyRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000904F0 File Offset: 0x0008E6F0
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x0000D185 File Offset: 0x0000B385
		public unsafe XmlQualifiedName QnXsdSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00090520 File Offset: 0x0008E720
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		public unsafe XmlQualifiedName QnXsdField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00090550 File Offset: 0x0008E750
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public unsafe XmlQualifiedName QnXsdMinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00090580 File Offset: 0x0008E780
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x0000D1E2 File Offset: 0x0000B3E2
		public unsafe XmlQualifiedName QnXsdMinInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000905B0 File Offset: 0x0008E7B0
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0000D201 File Offset: 0x0000B401
		public unsafe XmlQualifiedName QnXsdMaxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000905E0 File Offset: 0x0008E7E0
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000D220 File Offset: 0x0000B420
		public unsafe XmlQualifiedName QnXsdMaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00090610 File Offset: 0x0008E810
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000D23F File Offset: 0x0000B43F
		public unsafe XmlQualifiedName QnXsdTotalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00090640 File Offset: 0x0008E840
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0000D25E File Offset: 0x0000B45E
		public unsafe XmlQualifiedName QnXsdFractionDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00090670 File Offset: 0x0008E870
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x0000D27D File Offset: 0x0000B47D
		public unsafe XmlQualifiedName QnXsdLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x000906A0 File Offset: 0x0008E8A0
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x0000D29C File Offset: 0x0000B49C
		public unsafe XmlQualifiedName QnXsdMinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000906D0 File Offset: 0x0008E8D0
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0000D2BB File Offset: 0x0000B4BB
		public unsafe XmlQualifiedName QnXsdMaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00090700 File Offset: 0x0008E900
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0000D2DA File Offset: 0x0000B4DA
		public unsafe XmlQualifiedName QnXsdEnumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00090730 File Offset: 0x0008E930
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
		public unsafe XmlQualifiedName QnXsdPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdPattern);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdPattern), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00090760 File Offset: 0x0008E960
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0000D318 File Offset: 0x0000B518
		public unsafe XmlQualifiedName QnXsdDocumentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00090790 File Offset: 0x0008E990
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x0000D337 File Offset: 0x0000B537
		public unsafe XmlQualifiedName QnXsdAppinfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x000907C0 File Offset: 0x0008E9C0
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0000D356 File Offset: 0x0000B556
		public unsafe XmlQualifiedName QnSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x000907F0 File Offset: 0x0008E9F0
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0000D375 File Offset: 0x0000B575
		public unsafe XmlQualifiedName QnXsdComplexContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00090820 File Offset: 0x0008EA20
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0000D394 File Offset: 0x0000B594
		public unsafe XmlQualifiedName QnXsdSimpleContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00090850 File Offset: 0x0008EA50
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0000D3B3 File Offset: 0x0000B5B3
		public unsafe XmlQualifiedName QnXsdRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00090880 File Offset: 0x0008EA80
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0000D3D2 File Offset: 0x0000B5D2
		public unsafe XmlQualifiedName QnXsdExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x000908B0 File Offset: 0x0008EAB0
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000D3F1 File Offset: 0x0000B5F1
		public unsafe XmlQualifiedName QnXsdUnion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x000908E0 File Offset: 0x0008EAE0
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0000D410 File Offset: 0x0000B610
		public unsafe XmlQualifiedName QnXsdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00090910 File Offset: 0x0008EB10
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000D42F File Offset: 0x0000B62F
		public unsafe XmlQualifiedName QnXsdWhiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00090940 File Offset: 0x0008EB40
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000D44E File Offset: 0x0000B64E
		public unsafe XmlQualifiedName QnXsdRedefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRedefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRedefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00090970 File Offset: 0x0008EB70
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000D46D File Offset: 0x0000B66D
		public unsafe XmlQualifiedName QnXsdAnyType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x000909A0 File Offset: 0x0008EBA0
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000D48C File Offset: 0x0000B68C
		public unsafe Il2CppReferenceArray<XmlQualifiedName> TokenToQName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_TokenToQName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_TokenToQName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeFieldInfoPtr_NsDataType;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_NsDataTypeAlias;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeFieldInfoPtr_NsDataTypeOld;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_NsXml;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_NsXdr;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeFieldInfoPtr_NsXdrAlias;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeFieldInfoPtr_XdrSchema;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeFieldInfoPtr_QnPCData;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeFieldInfoPtr_QnXml;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeFieldInfoPtr_QnXmlNs;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeFieldInfoPtr_QnDtDt;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeFieldInfoPtr_QnXmlLang;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeFieldInfoPtr_QnName;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeFieldInfoPtr_QnType;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeFieldInfoPtr_QnMaxOccurs;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeFieldInfoPtr_QnMinOccurs;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeFieldInfoPtr_QnInfinite;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeFieldInfoPtr_QnModel;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeFieldInfoPtr_QnOpen;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeFieldInfoPtr_QnClosed;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeFieldInfoPtr_QnContent;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeFieldInfoPtr_QnMixed;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeFieldInfoPtr_QnEmpty;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeFieldInfoPtr_QnEltOnly;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeFieldInfoPtr_QnTextOnly;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeFieldInfoPtr_QnOrder;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeFieldInfoPtr_QnSeq;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeFieldInfoPtr_QnOne;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeFieldInfoPtr_QnMany;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_QnRequired;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_QnYes;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_QnNo;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_QnString;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr_QnID;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr_QnIDRef;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr_QnIDRefs;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr_QnEntity;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_QnEntities;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_QnNmToken;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_QnNmTokens;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_QnEnumeration;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_QnDefault;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrSchema;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrElementType;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrElement;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrGroup;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAttributeType;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAttribute;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrDataType;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrDescription;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrExtends;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAliasSchema;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_QnDtType;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_QnDtValues;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMaxLength;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMinLength;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMax;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMin;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMinExclusive;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMaxExclusive;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeFieldInfoPtr_QnTargetNamespace;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_QnVersion;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeFieldInfoPtr_QnFinalDefault;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr_QnBlockDefault;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeFieldInfoPtr_QnFixed;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeFieldInfoPtr_QnAbstract;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeFieldInfoPtr_QnBlock;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeFieldInfoPtr_QnSubstitutionGroup;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeFieldInfoPtr_QnFinal;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeFieldInfoPtr_QnNillable;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeFieldInfoPtr_QnRef;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeFieldInfoPtr_QnBase;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeFieldInfoPtr_QnDerivedBy;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr_QnNamespace;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr_QnProcessContents;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeFieldInfoPtr_QnRefer;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeFieldInfoPtr_QnPublic;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeFieldInfoPtr_QnSystem;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr_QnSchemaLocation;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr_QnValue;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr_QnUse;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr_QnForm;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr_QnElementFormDefault;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr_QnAttributeFormDefault;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr_QnItemType;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeFieldInfoPtr_QnMemberTypes;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeFieldInfoPtr_QnXPath;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSchema;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnnotation;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdInclude;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdImport;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdElement;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAttribute;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAttributeGroup;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnyAttribute;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdGroup;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAll;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdChoice;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSequence;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAny;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdNotation;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSimpleType;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdComplexType;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdUnique;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdKey;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdKeyRef;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSelector;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdField;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinExclusive;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinInclusive;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxInclusive;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxExclusive;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdTotalDigits;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdFractionDigits;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdLength;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinLength;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxLength;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdEnumeration;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdPattern;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdDocumentation;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAppinfo;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeFieldInfoPtr_QnSource;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdComplexContent;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSimpleContent;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdRestriction;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdExtension;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdUnion;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdList;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdWhiteSpace;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdRedefine;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnyType;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeFieldInfoPtr_TokenToQName;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0;

		// Token: 0x02000237 RID: 567
		[OriginalName("System.Xml.dll", "", "Token")]
		public enum Token
		{
			// Token: 0x040022C8 RID: 8904
			Empty,
			// Token: 0x040022C9 RID: 8905
			SchemaName,
			// Token: 0x040022CA RID: 8906
			SchemaType,
			// Token: 0x040022CB RID: 8907
			SchemaMaxOccurs,
			// Token: 0x040022CC RID: 8908
			SchemaMinOccurs,
			// Token: 0x040022CD RID: 8909
			SchemaInfinite,
			// Token: 0x040022CE RID: 8910
			SchemaModel,
			// Token: 0x040022CF RID: 8911
			SchemaOpen,
			// Token: 0x040022D0 RID: 8912
			SchemaClosed,
			// Token: 0x040022D1 RID: 8913
			SchemaContent,
			// Token: 0x040022D2 RID: 8914
			SchemaMixed,
			// Token: 0x040022D3 RID: 8915
			SchemaEmpty,
			// Token: 0x040022D4 RID: 8916
			SchemaElementOnly,
			// Token: 0x040022D5 RID: 8917
			SchemaTextOnly,
			// Token: 0x040022D6 RID: 8918
			SchemaOrder,
			// Token: 0x040022D7 RID: 8919
			SchemaSeq,
			// Token: 0x040022D8 RID: 8920
			SchemaOne,
			// Token: 0x040022D9 RID: 8921
			SchemaMany,
			// Token: 0x040022DA RID: 8922
			SchemaRequired,
			// Token: 0x040022DB RID: 8923
			SchemaYes,
			// Token: 0x040022DC RID: 8924
			SchemaNo,
			// Token: 0x040022DD RID: 8925
			SchemaString,
			// Token: 0x040022DE RID: 8926
			SchemaId,
			// Token: 0x040022DF RID: 8927
			SchemaIdref,
			// Token: 0x040022E0 RID: 8928
			SchemaIdrefs,
			// Token: 0x040022E1 RID: 8929
			SchemaEntity,
			// Token: 0x040022E2 RID: 8930
			SchemaEntities,
			// Token: 0x040022E3 RID: 8931
			SchemaNmtoken,
			// Token: 0x040022E4 RID: 8932
			SchemaNmtokens,
			// Token: 0x040022E5 RID: 8933
			SchemaEnumeration,
			// Token: 0x040022E6 RID: 8934
			SchemaDefault,
			// Token: 0x040022E7 RID: 8935
			XdrRoot,
			// Token: 0x040022E8 RID: 8936
			XdrElementType,
			// Token: 0x040022E9 RID: 8937
			XdrElement,
			// Token: 0x040022EA RID: 8938
			XdrGroup,
			// Token: 0x040022EB RID: 8939
			XdrAttributeType,
			// Token: 0x040022EC RID: 8940
			XdrAttribute,
			// Token: 0x040022ED RID: 8941
			XdrDatatype,
			// Token: 0x040022EE RID: 8942
			XdrDescription,
			// Token: 0x040022EF RID: 8943
			XdrExtends,
			// Token: 0x040022F0 RID: 8944
			SchemaXdrRootAlias,
			// Token: 0x040022F1 RID: 8945
			SchemaDtType,
			// Token: 0x040022F2 RID: 8946
			SchemaDtValues,
			// Token: 0x040022F3 RID: 8947
			SchemaDtMaxLength,
			// Token: 0x040022F4 RID: 8948
			SchemaDtMinLength,
			// Token: 0x040022F5 RID: 8949
			SchemaDtMax,
			// Token: 0x040022F6 RID: 8950
			SchemaDtMin,
			// Token: 0x040022F7 RID: 8951
			SchemaDtMinExclusive,
			// Token: 0x040022F8 RID: 8952
			SchemaDtMaxExclusive,
			// Token: 0x040022F9 RID: 8953
			SchemaTargetNamespace,
			// Token: 0x040022FA RID: 8954
			SchemaVersion,
			// Token: 0x040022FB RID: 8955
			SchemaFinalDefault,
			// Token: 0x040022FC RID: 8956
			SchemaBlockDefault,
			// Token: 0x040022FD RID: 8957
			SchemaFixed,
			// Token: 0x040022FE RID: 8958
			SchemaAbstract,
			// Token: 0x040022FF RID: 8959
			SchemaBlock,
			// Token: 0x04002300 RID: 8960
			SchemaSubstitutionGroup,
			// Token: 0x04002301 RID: 8961
			SchemaFinal,
			// Token: 0x04002302 RID: 8962
			SchemaNillable,
			// Token: 0x04002303 RID: 8963
			SchemaRef,
			// Token: 0x04002304 RID: 8964
			SchemaBase,
			// Token: 0x04002305 RID: 8965
			SchemaDerivedBy,
			// Token: 0x04002306 RID: 8966
			SchemaNamespace,
			// Token: 0x04002307 RID: 8967
			SchemaProcessContents,
			// Token: 0x04002308 RID: 8968
			SchemaRefer,
			// Token: 0x04002309 RID: 8969
			SchemaPublic,
			// Token: 0x0400230A RID: 8970
			SchemaSystem,
			// Token: 0x0400230B RID: 8971
			SchemaSchemaLocation,
			// Token: 0x0400230C RID: 8972
			SchemaValue,
			// Token: 0x0400230D RID: 8973
			SchemaSource,
			// Token: 0x0400230E RID: 8974
			SchemaAttributeFormDefault,
			// Token: 0x0400230F RID: 8975
			SchemaElementFormDefault,
			// Token: 0x04002310 RID: 8976
			SchemaUse,
			// Token: 0x04002311 RID: 8977
			SchemaForm,
			// Token: 0x04002312 RID: 8978
			XsdSchema,
			// Token: 0x04002313 RID: 8979
			XsdAnnotation,
			// Token: 0x04002314 RID: 8980
			XsdInclude,
			// Token: 0x04002315 RID: 8981
			XsdImport,
			// Token: 0x04002316 RID: 8982
			XsdElement,
			// Token: 0x04002317 RID: 8983
			XsdAttribute,
			// Token: 0x04002318 RID: 8984
			xsdAttributeGroup,
			// Token: 0x04002319 RID: 8985
			XsdAnyAttribute,
			// Token: 0x0400231A RID: 8986
			XsdGroup,
			// Token: 0x0400231B RID: 8987
			XsdAll,
			// Token: 0x0400231C RID: 8988
			XsdChoice,
			// Token: 0x0400231D RID: 8989
			XsdSequence,
			// Token: 0x0400231E RID: 8990
			XsdAny,
			// Token: 0x0400231F RID: 8991
			XsdNotation,
			// Token: 0x04002320 RID: 8992
			XsdSimpleType,
			// Token: 0x04002321 RID: 8993
			XsdComplexType,
			// Token: 0x04002322 RID: 8994
			XsdUnique,
			// Token: 0x04002323 RID: 8995
			XsdKey,
			// Token: 0x04002324 RID: 8996
			XsdKeyref,
			// Token: 0x04002325 RID: 8997
			XsdSelector,
			// Token: 0x04002326 RID: 8998
			XsdField,
			// Token: 0x04002327 RID: 8999
			XsdMinExclusive,
			// Token: 0x04002328 RID: 9000
			XsdMinInclusive,
			// Token: 0x04002329 RID: 9001
			XsdMaxExclusive,
			// Token: 0x0400232A RID: 9002
			XsdMaxInclusive,
			// Token: 0x0400232B RID: 9003
			XsdTotalDigits,
			// Token: 0x0400232C RID: 9004
			XsdFractionDigits,
			// Token: 0x0400232D RID: 9005
			XsdLength,
			// Token: 0x0400232E RID: 9006
			XsdMinLength,
			// Token: 0x0400232F RID: 9007
			XsdMaxLength,
			// Token: 0x04002330 RID: 9008
			XsdEnumeration,
			// Token: 0x04002331 RID: 9009
			XsdPattern,
			// Token: 0x04002332 RID: 9010
			XsdDocumentation,
			// Token: 0x04002333 RID: 9011
			XsdAppInfo,
			// Token: 0x04002334 RID: 9012
			XsdComplexContent,
			// Token: 0x04002335 RID: 9013
			XsdComplexContentExtension,
			// Token: 0x04002336 RID: 9014
			XsdComplexContentRestriction,
			// Token: 0x04002337 RID: 9015
			XsdSimpleContent,
			// Token: 0x04002338 RID: 9016
			XsdSimpleContentExtension,
			// Token: 0x04002339 RID: 9017
			XsdSimpleContentRestriction,
			// Token: 0x0400233A RID: 9018
			XsdSimpleTypeList,
			// Token: 0x0400233B RID: 9019
			XsdSimpleTypeRestriction,
			// Token: 0x0400233C RID: 9020
			XsdSimpleTypeUnion,
			// Token: 0x0400233D RID: 9021
			XsdWhitespace,
			// Token: 0x0400233E RID: 9022
			XsdRedefine,
			// Token: 0x0400233F RID: 9023
			SchemaItemType,
			// Token: 0x04002340 RID: 9024
			SchemaMemberTypes,
			// Token: 0x04002341 RID: 9025
			SchemaXPath,
			// Token: 0x04002342 RID: 9026
			XmlLang
		}
	}
}
