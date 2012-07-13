//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
namespace JetBrains.ReSharper.Psi.FSharp {
  public abstract partial class TreeNodeVisitor {
    public virtual void VisitNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Tree.ITreeNode node)
    {
    }
    public virtual void VisitFSharpFileNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFSharpFileNode FSharpFileParam) {
      VisitNode (FSharpFileParam);
    }
    public virtual void VisitAlgebraicTypeRepresentationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAlgebraicTypeRepresentationNode algebraicTypeRepresentationParam) {
      VisitTypeRepresentationNode (algebraicTypeRepresentationParam);
    }
    public virtual void VisitAndExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAndExpressionNode andExpressionParam) {
      VisitNode (andExpressionParam);
    }
    public virtual void VisitApplicationExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IApplicationExpressionNode applicationExpressionParam) {
      VisitExpressionNode (applicationExpressionParam);
    }
    public virtual void VisitArrayExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IArrayExpressionNode arrayExpressionParam) {
      VisitExpressionNode (arrayExpressionParam);
    }
    public virtual void VisitArrayPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IArrayPatternNode arrayPatternParam) {
      VisitPatternNode (arrayPatternParam);
    }
    public virtual void VisitArrayTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IArrayTypeNode arrayTypeParam) {
      VisitTypeExpressionNode (arrayTypeParam);
    }
    public virtual void VisitAsValuePatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IAsValuePatternNode asValuePatternParam) {
      VisitPatternNode (asValuePatternParam);
    }
    public virtual void VisitAssertExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssertExpressionNode assertExpressionParam) {
      VisitExpressionNode (assertExpressionParam);
    }
    public virtual void VisitAssignExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssignExpressionNode assignExpressionParam) {
      VisitNode (assignExpressionParam);
    }
    public virtual void VisitAssignFieldExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAssignFieldExpressionNode assignFieldExpressionParam) {
      VisitNode (assignFieldExpressionParam);
    }
    public virtual void VisitAttributeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAttributeNode attributeParam) {
      VisitNode (attributeParam);
    }
    public virtual void VisitAttributeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IAttributeReferenceNode attributeReferenceParam) {
      VisitNode (attributeReferenceParam);
    }
    public virtual void VisitBinaryAddExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryAddExpressionNode binaryAddExpressionParam) {
      VisitNode (binaryAddExpressionParam);
    }
    public virtual void VisitBinaryExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryExpressionNode binaryExpressionParam) {
      VisitOperatorExpressionNode (binaryExpressionParam);
    }
    public virtual void VisitBinaryMultExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryMultExpressionNode binaryMultExpressionParam) {
      VisitNode (binaryMultExpressionParam);
    }
    public virtual void VisitBinaryPowerExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBinaryPowerExpressionNode binaryPowerExpressionParam) {
      VisitNode (binaryPowerExpressionParam);
    }
    public virtual void VisitBindingNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IBindingNode bindingParam) {
      VisitBindingSchemeNode (bindingParam);
    }
    public virtual void VisitBindingPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBindingPatternNode bindingPatternParam) {
      VisitBindingSourceNode (bindingPatternParam);
    }
    public virtual void VisitBindingSchemeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode bindingSchemeParam) {
      VisitNode (bindingSchemeParam);
    }
    public virtual void VisitBindingSourceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IBindingSourceNode bindingSourceParam) {
      VisitNode (bindingSourceParam);
    }
    public virtual void VisitBindingValueNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IBindingValueNode bindingValueParam) {
      VisitBindingValueSchemeNode (bindingValueParam);
    }
    public virtual void VisitBindingValueSchemeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBindingValueSchemeNode bindingValueSchemeParam) {
      VisitBindingSourceNode (bindingValueSchemeParam);
    }
    public virtual void VisitBracketedExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedExpressionNode bracketedExpressionParam) {
      VisitExpressionNode (bracketedExpressionParam);
    }
    public virtual void VisitBracketedFieldValueExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedFieldValueExpressionNode bracketedFieldValueExpressionParam) {
      VisitExpressionNode (bracketedFieldValueExpressionParam);
    }
    public virtual void VisitBracketedPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IBracketedPatternNode bracketedPatternParam) {
      VisitPatternNode (bracketedPatternParam);
    }
    public virtual void VisitComparisonExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IComparisonExpressionNode comparisonExpressionParam) {
      VisitNode (comparisonExpressionParam);
    }
    public virtual void VisitConstantExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstantExpressionNode constantExpressionParam) {
      VisitExpressionNode (constantExpressionParam);
    }
    public virtual void VisitConstantPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstantPatternNode constantPatternParam) {
      VisitPatternNode (constantPatternParam);
    }
    public virtual void VisitConstructorDeclarationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorDeclarationNode constructorDeclarationParam) {
      VisitNode (constructorDeclarationParam);
    }
    public virtual void VisitConstructorReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IConstructorReferenceNode constructorReferenceParam) {
      VisitPatternNode (constructorReferenceParam);
    }
    public virtual void VisitCreationExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ICreationExpressionNode creationExpressionParam) {
      VisitExpressionNode (creationExpressionParam);
    }
    public virtual void VisitCreationWithOverridingMethodsExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ICreationWithOverridingMethodsExpressionNode creationWithOverridingMethodsExpressionParam) {
      VisitExpressionNode (creationWithOverridingMethodsExpressionParam);
    }
    public virtual void VisitDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IDefinitionNode definitionParam) {
      VisitNode (definitionParam);
    }
    public virtual void VisitDisjunctionPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDisjunctionPatternNode disjunctionPatternParam) {
      VisitPatternNode (disjunctionPatternParam);
    }
    public virtual void VisitDoExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDoExpressionNode doExpressionParam) {
      VisitBindingSchemeNode (doExpressionParam);
    }
    public virtual void VisitDoExpressionDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IDoExpressionDefinitionNode doExpressionDefinitionParam) {
      VisitDefinitionNode (doExpressionDefinitionParam);
    }
    public virtual void VisitDowncastExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDowncastExpressionNode downcastExpressionParam) {
      VisitExpressionNode (downcastExpressionParam);
    }
    public virtual void VisitDowncastExpressionToTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IDowncastExpressionToTypeNode downcastExpressionToTypeParam) {
      VisitExpressionNode (downcastExpressionToTypeParam);
    }
    public virtual void VisitEmptyArrayNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IEmptyArrayNode emptyArrayParam) {
      VisitNode (emptyArrayParam);
    }
    public virtual void VisitEmptyListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IEmptyListNode emptyListParam) {
      VisitNode (emptyListParam);
    }
    public virtual void VisitExceptionAliasNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionAliasNode exceptionAliasParam) {
      VisitExceptionDefinitionNode (exceptionAliasParam);
    }
    public virtual void VisitExceptionDeclarationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionDeclarationNode exceptionDeclarationParam) {
      VisitExceptionDefinitionNode (exceptionDeclarationParam);
    }
    public virtual void VisitExceptionDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionDefinitionNode exceptionDefinitionParam) {
      VisitNode (exceptionDefinitionParam);
    }
    public virtual void VisitExceptionReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExceptionReferenceNode exceptionReferenceParam) {
      VisitNode (exceptionReferenceParam);
    }
    public virtual void VisitExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode expressionParam) {
      VisitNode (expressionParam);
    }
    public virtual void VisitExpressionBlockNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IExpressionBlockNode expressionBlockParam) {
      VisitExpressionNode (expressionBlockParam);
    }
    public virtual void VisitExpressionSequenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IExpressionSequenceNode expressionSequenceParam) {
      VisitExpressionNode (expressionSequenceParam);
    }
    public virtual void VisitFieldAssignmentNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentNode fieldAssignmentParam) {
      VisitNode (fieldAssignmentParam);
    }
    public virtual void VisitFieldAssignmentListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldAssignmentListNode fieldAssignmentListParam) {
      VisitNode (fieldAssignmentListParam);
    }
    public virtual void VisitFieldDeclarationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFieldDeclarationNode fieldDeclarationParam) {
      VisitNode (fieldDeclarationParam);
    }
    public virtual void VisitFieldDeclarationListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldDeclarationListNode fieldDeclarationListParam) {
      VisitNode (fieldDeclarationListParam);
    }
    public virtual void VisitFieldPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldPatternNode fieldPatternParam) {
      VisitNode (fieldPatternParam);
    }
    public virtual void VisitFieldPatternListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFieldPatternListNode fieldPatternListParam) {
      VisitNode (fieldPatternListParam);
    }
    public virtual void VisitFieldReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFieldReferenceNode fieldReferenceParam) {
      VisitNode (fieldReferenceParam);
    }
    public virtual void VisitForAllTypeExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IForAllTypeExpressionNode forAllTypeExpressionParam) {
      VisitTypeSchemeExpressionNode (forAllTypeExpressionParam);
    }
    public virtual void VisitForStatementExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IForStatementExpressionNode forStatementExpressionParam) {
      VisitExpressionNode (forStatementExpressionParam);
    }
    public virtual void VisitFunExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFunExpressionNode funExpressionParam) {
      VisitExpressionNode (funExpressionParam);
    }
    public virtual void VisitFunctionExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IFunctionExpressionNode functionExpressionParam) {
      VisitExpressionNode (functionExpressionParam);
    }
    public virtual void VisitFunctionTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IFunctionTypeNode functionTypeParam) {
      VisitTypeExpressionNode (functionTypeParam);
    }
    public virtual void VisitIdReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IIdReferenceNode idReferenceParam) {
      VisitNode (idReferenceParam);
    }
    public virtual void VisitIfStatementExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IIfStatementExpressionNode ifStatementExpressionParam) {
      VisitExpressionNode (ifStatementExpressionParam);
    }
    public virtual void VisitImplementationUnitNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IImplementationUnitNode implementationUnitParam) {
      VisitNode (implementationUnitParam);
    }
    public virtual void VisitInfixOperatorExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IInfixOperatorExpressionNode infixOperatorExpressionParam) {
      VisitNode (infixOperatorExpressionParam);
    }
    public virtual void VisitInterfaceUnitNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IInterfaceUnitNode interfaceUnitParam) {
      VisitNode (interfaceUnitParam);
    }
    public virtual void VisitLazyExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ILazyExpressionNode lazyExpressionParam) {
      VisitExpressionNode (lazyExpressionParam);
    }
    public virtual void VisitLazyTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILazyTypeNode lazyTypeParam) {
      VisitTypeExpressionNode (lazyTypeParam);
    }
    public virtual void VisitLetDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILetDefinitionNode letDefinitionParam) {
      VisitDefinitionNode (letDefinitionParam);
    }
    public virtual void VisitListConcatenateExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpressionNode listConcatenateExpressionParam) {
      VisitNode (listConcatenateExpressionParam);
    }
    public virtual void VisitListConstructorExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConstructorExpressionNode listConstructorExpressionParam) {
      VisitNode (listConstructorExpressionParam);
    }
    public virtual void VisitListConstructorPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IListConstructorPatternNode listConstructorPatternParam) {
      VisitPatternNode (listConstructorPatternParam);
    }
    public virtual void VisitLocalDeclarationsInExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ILocalDeclarationsInExpressionNode localDeclarationsInExpressionParam) {
      VisitExpressionNode (localDeclarationsInExpressionParam);
    }
    public virtual void VisitMatchClauseNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMatchClauseNode matchClauseParam) {
      VisitNode (matchClauseParam);
    }
    public virtual void VisitMatchExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IMatchExpressionNode matchExpressionParam) {
      VisitExpressionNode (matchExpressionParam);
    }
    public virtual void VisitMemberAccessExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMemberAccessExpressionNode memberAccessExpressionParam) {
      VisitExpressionNode (memberAccessExpressionParam);
    }
    public virtual void VisitModuleReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceNode moduleReferenceParam) {
      VisitNode (moduleReferenceParam);
    }
    public virtual void VisitModuleReferenceListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceListNode moduleReferenceListParam) {
      VisitNode (moduleReferenceListParam);
    }
    public virtual void VisitModuleReferenceOldNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IModuleReferenceOldNode moduleReferenceOldParam) {
      VisitNode (moduleReferenceOldParam);
    }
    public virtual void VisitMultiParameterTypeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMultiParameterTypeReferenceNode multiParameterTypeReferenceParam) {
      VisitNode (multiParameterTypeReferenceParam);
    }
    public virtual void VisitMultipleMatchingNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMultipleMatchingNode multipleMatchingParam) {
      VisitNode (multipleMatchingParam);
    }
    public virtual void VisitMutableBindingValueNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IMutableBindingValueNode mutableBindingValueParam) {
      VisitBindingValueSchemeNode (mutableBindingValueParam);
    }
    public virtual void VisitOneParameterTypeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOneParameterTypeReferenceNode oneParameterTypeReferenceParam) {
      VisitNode (oneParameterTypeReferenceParam);
    }
    public virtual void VisitOpenModuleDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOpenModuleDefinitionNode openModuleDefinitionParam) {
      VisitNode (openModuleDefinitionParam);
    }
    public virtual void VisitOperatorExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOperatorExpressionNode operatorExpressionParam) {
      VisitNode (operatorExpressionParam);
    }
    public virtual void VisitOperatorNameNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IOperatorNameNode operatorNameParam) {
      VisitValueNameNode (operatorNameParam);
    }
    public virtual void VisitOrExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IOrExpressionNode orExpressionParam) {
      VisitNode (orExpressionParam);
    }
    public virtual void VisitParameterizedConstructorPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IParameterizedConstructorPatternNode parameterizedConstructorPatternParam) {
      VisitPatternNode (parameterizedConstructorPatternParam);
    }
    public virtual void VisitParameterizedTypeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IParameterizedTypeReferenceNode parameterizedTypeReferenceParam) {
      VisitNode (parameterizedTypeReferenceParam);
    }
    public virtual void VisitParenthesizedExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedExpressionNode parenthesizedExpressionParam) {
      VisitExpressionNode (parenthesizedExpressionParam);
    }
    public virtual void VisitParenthesizedFieldValueExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedFieldValueExpressionNode parenthesizedFieldValueExpressionParam) {
      VisitExpressionNode (parenthesizedFieldValueExpressionParam);
    }
    public virtual void VisitParenthesizedPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IParenthesizedPatternNode parenthesizedPatternParam) {
      VisitPatternNode (parenthesizedPatternParam);
    }
    public virtual void VisitParenthesizedTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IParenthesizedTypeNode parenthesizedTypeParam) {
      VisitTypeExpressionNode (parenthesizedTypeParam);
    }
    public virtual void VisitPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode patternParam) {
      VisitNode (patternParam);
    }
    public virtual void VisitPatternMatchingNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IPatternMatchingNode patternMatchingParam) {
      VisitNode (patternMatchingParam);
    }
    public virtual void VisitPrefixOperatorExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IPrefixOperatorExpressionNode prefixOperatorExpressionParam) {
      VisitNode (prefixOperatorExpressionParam);
    }
    public virtual void VisitQualifiedIdReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IQualifiedIdReferenceNode qualifiedIdReferenceParam) {
      VisitValueReferenceExpressionOldNode (qualifiedIdReferenceParam);
    }
    public virtual void VisitQualifiedIdentifierNameNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedIdentifierNameNode qualifiedIdentifierNameParam) {
      VisitNode (qualifiedIdentifierNameParam);
    }
    public virtual void VisitQualifiedValueNameNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedValueNameNode qualifiedValueNameParam) {
      VisitNode (qualifiedValueNameParam);
    }
    public virtual void VisitQualifiedValueReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IQualifiedValueReferenceNode qualifiedValueReferenceParam) {
      VisitValueReferenceExpressionOldNode (qualifiedValueReferenceParam);
    }
    public virtual void VisitRangePatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRangePatternNode rangePatternParam) {
      VisitPatternNode (rangePatternParam);
    }
    public virtual void VisitRecordExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordExpressionNode recordExpressionParam) {
      VisitExpressionNode (recordExpressionParam);
    }
    public virtual void VisitRecordPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordPatternNode recordPatternParam) {
      VisitPatternNode (recordPatternParam);
    }
    public virtual void VisitRecordTypeRepresentationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IRecordTypeRepresentationNode recordTypeRepresentationParam) {
      VisitTypeRepresentationNode (recordTypeRepresentationParam);
    }
    public virtual void VisitSpecificationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ISpecificationNode specificationParam) {
      VisitNode (specificationParam);
    }
    public virtual void VisitStringConcatenateExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IStringConcatenateExpressionNode stringConcatenateExpressionParam) {
      VisitNode (stringConcatenateExpressionParam);
    }
    public virtual void VisitTryFinallyExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITryFinallyExpressionNode tryFinallyExpressionParam) {
      VisitExpressionNode (tryFinallyExpressionParam);
    }
    public virtual void VisitTryWithExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITryWithExpressionNode tryWithExpressionParam) {
      VisitExpressionNode (tryWithExpressionParam);
    }
    public virtual void VisitTupleExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITupleExpressionNode tupleExpressionParam) {
      VisitExpressionNode (tupleExpressionParam);
    }
    public virtual void VisitTuplePatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITuplePatternNode tuplePatternParam) {
      VisitPatternNode (tuplePatternParam);
    }
    public virtual void VisitTupleTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITupleTypeNode tupleTypeParam) {
      VisitTypeExpressionNode (tupleTypeParam);
    }
    public virtual void VisitTypeDeclarationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode typeDeclarationParam) {
      VisitNode (typeDeclarationParam);
    }
    public virtual void VisitTypeDefinitionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinitionNode typeDefinitionParam) {
      VisitNode (typeDefinitionParam);
    }
    public virtual void VisitTypeExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeExpressionNode typeExpressionParam) {
      VisitNode (typeExpressionParam);
    }
    public virtual void VisitTypeInformationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeInformationNode typeInformationParam) {
      VisitNode (typeInformationParam);
    }
    public virtual void VisitTypeParameterDeclarationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterDeclarationNode typeParameterDeclarationParam) {
      VisitNode (typeParameterDeclarationParam);
    }
    public virtual void VisitTypeParameterListNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeParameterListNode typeParameterListParam) {
      VisitNode (typeParameterListParam);
    }
    public virtual void VisitTypeParameterReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeParameterReferenceNode typeParameterReferenceParam) {
      VisitTypeExpressionNode (typeParameterReferenceParam);
    }
    public virtual void VisitTypeRefOrConstructorDeclNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeRefOrConstructorDeclNode typeRefOrConstructorDeclParam) {
      VisitTypeInformationNode (typeRefOrConstructorDeclParam);
    }
    public virtual void VisitTypeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.ITypeReferenceNode typeReferenceParam) {
      VisitNode (typeReferenceParam);
    }
    public virtual void VisitTypeRepresentationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeRepresentationNode typeRepresentationParam) {
      VisitTypeInformationNode (typeRepresentationParam);
    }
    public virtual void VisitTypeSchemeExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeSchemeExpressionNode typeSchemeExpressionParam) {
      VisitNode (typeSchemeExpressionParam);
    }
    public virtual void VisitTypeTestExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeTestExpressionNode typeTestExpressionParam) {
      VisitExpressionNode (typeTestExpressionParam);
    }
    public virtual void VisitTypeTestPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypeTestPatternNode typeTestPatternParam) {
      VisitPatternNode (typeTestPatternParam);
    }
    public virtual void VisitTypedExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypedExpressionNode typedExpressionParam) {
      VisitExpressionNode (typedExpressionParam);
    }
    public virtual void VisitTypedPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.ITypedPatternNode typedPatternParam) {
      VisitPatternNode (typedPatternParam);
    }
    public virtual void VisitUnaryExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnaryExpressionNode unaryExpressionParam) {
      VisitOperatorExpressionNode (unaryExpressionParam);
    }
    public virtual void VisitUnaryMinusExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnaryMinusExpressionNode unaryMinusExpressionParam) {
      VisitNode (unaryMinusExpressionParam);
    }
    public virtual void VisitUnderlinePatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnderlinePatternNode underlinePatternParam) {
      VisitPatternNode (underlinePatternParam);
    }
    public virtual void VisitUnderlineTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IUnderlineTypeNode underlineTypeParam) {
      VisitTypeExpressionNode (underlineTypeParam);
    }
    public virtual void VisitUnitNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUnitNode unitParam) {
      VisitNode (unitParam);
    }
    public virtual void VisitUpcastExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUpcastExpressionNode upcastExpressionParam) {
      VisitExpressionNode (upcastExpressionParam);
    }
    public virtual void VisitUpcastExpressionToTypeNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IUpcastExpressionToTypeNode upcastExpressionToTypeParam) {
      VisitExpressionNode (upcastExpressionToTypeParam);
    }
    public virtual void VisitValueDeclarationPatternNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueDeclarationPatternNode valueDeclarationPatternParam) {
      VisitPatternNode (valueDeclarationPatternParam);
    }
    public virtual void VisitValueNameNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueNameNode valueNameParam) {
      VisitNode (valueNameParam);
    }
    public virtual void VisitValueReferenceExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueReferenceExpressionNode valueReferenceExpressionParam) {
      VisitExpressionNode (valueReferenceExpressionParam);
    }
    public virtual void VisitValueReferenceExpressionOldNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IValueReferenceExpressionOldNode valueReferenceExpressionOldParam) {
      VisitNode (valueReferenceExpressionOldParam);
    }
    public virtual void VisitValueSpecificationNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IValueSpecificationNode valueSpecificationParam) {
      VisitNode (valueSpecificationParam);
    }
    public virtual void VisitWhileStatementExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IWhileStatementExpressionNode whileStatementExpressionParam) {
      VisitExpressionNode (whileStatementExpressionParam);
    }
    public virtual void VisitWithRecordExpressionNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.IWithRecordExpressionNode withRecordExpressionParam) {
      VisitExpressionNode (withRecordExpressionParam);
    }
    public virtual void VisitWithoutParameterTypeReferenceNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.FSharp.Tree.IWithoutParameterTypeReferenceNode withoutParameterTypeReferenceParam) {
      VisitNode (withoutParameterTypeReferenceParam);
    }
  }
}