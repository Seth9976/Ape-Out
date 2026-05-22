using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x02000005 RID: 5
	public class AstNode : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00014444 File Offset: 0x00012644
		// Note: this type is marked as 'beforefieldinit'.
		static AstNode()
		{
			Il2CppClassPointerStore<AstNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "AstNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstNode>.NativeClassPtr);
			AstNode.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100663301);
			AstNode.NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100663302);
			AstNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000144B0 File Offset: 0x000126B0
		public unsafe virtual AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AstNode.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000144F8 File Offset: 0x000126F8
		public unsafe virtual XPathResultType ReturnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AstNode.NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00014540 File Offset: 0x00012740
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020FA File Offset: 0x000002FA
		public AstNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001F1 RID: 497
		[OriginalName("System.Xml.dll", "", "AstType")]
		public enum AstType
		{
			// Token: 0x04001FA5 RID: 8101
			Axis,
			// Token: 0x04001FA6 RID: 8102
			Operator,
			// Token: 0x04001FA7 RID: 8103
			Filter,
			// Token: 0x04001FA8 RID: 8104
			ConstantOperand,
			// Token: 0x04001FA9 RID: 8105
			Function,
			// Token: 0x04001FAA RID: 8106
			Group,
			// Token: 0x04001FAB RID: 8107
			Root,
			// Token: 0x04001FAC RID: 8108
			Variable,
			// Token: 0x04001FAD RID: 8109
			Error
		}
	}
}
