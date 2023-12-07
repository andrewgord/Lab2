<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Materials List</title>
      </head>
      <body>
        <h1>Materials List</h1>
        <table border="1">
          <tr>
            <th>ID</th>
            <th>Author</th>
            <th>Title</th>
            <th>FaculcyName</th>
            <th>Department</th>
            <th>MaterialType</th>
            <th>Volume</th>
            <th>CreationDate</th>
          </tr>
          <xsl:apply-templates select="Materials/Material"/>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="Material">
    <tr>
      <td><xsl:value-of select="Id"/></td>
      <td><xsl:value-of select="Author"/></td>
      <td><xsl:value-of select="Title"/></td>
      <td><xsl:value-of select="FaculcyName"/></td>
      <td><xsl:value-of select="Department"/></td>
      <td><xsl:value-of select="MaterialType"/></td>
      <td><xsl:value-of select="Volume"/></td>
      <td><xsl:value-of select="CreationDate"/></td>
    </tr>
  </xsl:template>

</xsl:stylesheet>
